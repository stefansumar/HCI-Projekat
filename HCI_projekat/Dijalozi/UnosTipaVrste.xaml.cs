using HCI_projekat.Model;
using Microsoft.Win32;
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

namespace HCI_projekat.Unos
{
    /// <summary>
    /// Interaction logic for UnosTipaVrste.xaml
    /// </summary>
    public partial class UnosTipaVrste : Window, INotifyPropertyChanged
    {
        public UnosTipaVrste()
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SacuvajTip_ButtonClick(object sender, RoutedEventArgs e)
        {

            foreach(Tip t in MainWindow.tipovi)
            {
                if (t.Oznaka == OznakaTxt.Text)
                {
                    MessageBox.Show("Tip sa tom oznakom već postoji!", "Unos novog tipa");
                    return;
                }

            }

            if (OznakaTxt.Text == "" || NazivTxt.Text == "")
            {
                MessageBox.Show("Morate uneti oznaku i naziv tipa!", "Dodavanje novog tipa", MessageBoxButton.OK);
                return;
            }

            Tip tip = new Tip(oznaka, naziv, opis, slika);
            MainWindow.tipovi.Add(tip);


            System.Windows.MessageBox.Show("Uspešno ste dodali novi tip!", "Dodavanje novog tipa", MessageBoxButton.OK);
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

        private string naziv;
        public string Naziv
        {
            get { return naziv; }

            set
            {
                if (value != naziv)
                {
                    naziv = value;
                    OnPropertyChanged("Naziv");
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

        private string slika;
        public string Slika
        {
            get { return slika; }

            set
            {
                if (value != slika)
                {
                    slika = value;
                    OnPropertyChanged("Slika");
                }
            }
        }

        private void OdaberiIkonicu_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();


            fileDialog.Title = "Izaberi ikonicu";
            fileDialog.Filter = "Images|*.jpg;*.jpeg;*.png|" +
                                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                "Portable Network Graphic (*.png)|*.png";
            if (fileDialog.ShowDialog() == true)
            {
                ikonica.Source = new BitmapImage(new Uri(fileDialog.FileName));
                slika = ikonica.Source.ToString();
            }
        }
    }
}
