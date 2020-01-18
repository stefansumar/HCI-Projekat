using HCI_projekat.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;



namespace HCI_projekat.Unos
{
    /// <summary>
    /// Interaction logic for UnosEtikete.xaml
    /// </summary>
    public partial class UnosEtikete : Window, INotifyPropertyChanged
    {
        public static ObservableCollection<Etiketa> etikete = new ObservableCollection<Etiketa>();

        public UnosEtikete()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            this.DataContext = this;
        }

        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private string oznaka;
        public string Oznaka
        {
            get { return oznaka; }
            set
            {
                if (value != oznaka)
                {
                    oznaka = value;
                    OnPropertyChanged("Oznaka");
                }
            }
        }

        private string opis;
        public string Opis
        {
            get { return opis; }
            set
            {
                if (value != opis)
                {
                    opis = value;
                    OnPropertyChanged("Opis");
                }
            }
        }

        public ObservableCollection<Etiketa> Etikete
        {
            get { return etikete; }

            set
            {
                if (value != etikete)
                {
                    etikete = value;
                    OnPropertyChanged("Etikete");
                }
            }
        }

        private Color boja;

        public Color Boja
        {
            get { return boja; }
            set { boja = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private void Sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            foreach (Etiketa et in etikete)
            {
                if (et.Oznaka == OznakaTxt.Text)
                {
                    MessageBox.Show("Etiketa sa tom oznakom već postoji!", "Unos nove etikete");
                    return;
                }
            }

            if (OznakaTxt.Text == "")
            {
                MessageBox.Show("Morate uneti oznaku etikete!", "Dodavanje nove etikete");
                return;
            }

            Etiketa etiketa = new Etiketa(oznaka, opis, boja);
            etikete.Add(etiketa);
            System.Windows.MessageBox.Show("Uspešno ste dodali novu etiketu!", "Dodavanje nove etikete");
            this.Close();
        }
    }
}
