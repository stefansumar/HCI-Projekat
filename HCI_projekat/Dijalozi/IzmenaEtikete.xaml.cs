using HCI_projekat.Model;
using HCI_projekat.Unos;
using System;
using System.Collections.Generic;
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

namespace HCI_projekat.Dijalozi
{
    /// <summary>
    /// Interaction logic for IzmenaEtikete.xaml
    /// </summary>
    public partial class IzmenaEtikete : Window, INotifyPropertyChanged
    {
        public IzmenaEtikete()
        {
            InitializeComponent();
            CenterWindowOnScreen();
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        
        private string oznaka;
        public string Oznaka
        {
            get { return oznaka;  }

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

        private Color boja;
        public Color Boja
        {
            get { return boja; }

            set
            {
                if (value != boja)
                {
                    boja = value;
                    OnPropertyChanged("Boja");
                }
            }
        }

        private Etiketa pomocna;
        public IzmenaEtikete(Etiketa e)
        {
            InitializeComponent();
            CenterWindowOnScreen();
            Oznaka = e.Oznaka;
            Opis = e.Opis;
            Boja = e.Boja;
            pomocna = new Etiketa(e.Oznaka, e.Opis, e.Boja);
            this.DataContext = this;
            UnosEtikete.etikete.Remove(e);

        }

        private void SacuvajButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Etiketa et in UnosEtikete.etikete)
            {
                if (et.Oznaka == OznakaTxt.Text)
                {
                    MessageBox.Show("Etiketa sa tom oznakom već postoji!", "Unos nove etikete");
                    return;
                }
            }

            if (OznakaTxt.Text == "")
            {
                MessageBox.Show("Morate uneti oznaku etikete!", "Izmena etikete");
                return;
            }

            Etiketa etiketa = new Etiketa(oznaka, opis, boja);
            UnosEtikete.etikete.Add(etiketa);

            MessageBox.Show("Uspešno ste izmenili etiketu!", "Izmena etikete");
            this.Close();
        }

        private void OdustaniButton_Click(object sender, RoutedEventArgs e)
        {
            UnosEtikete.etikete.Add(pomocna);
            this.Close();
        }
    }
}
