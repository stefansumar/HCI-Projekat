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

namespace HCI_projekat.Dijalozi
{
    /// <summary>
    /// Interaction logic for IzmenaTipa.xaml
    /// </summary>
    public partial class IzmenaTipa : Window
    {
        public IzmenaTipa()
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

        private string ime;
        public string Ime
        {
            get { return ime; }
            set
            {
                if (value != ime)
                {
                    ime = value;
                    OnPropertyChanged("Ime");
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

        private Tip pomocni;
        public IzmenaTipa(Tip t)
        {
            InitializeComponent();
            CenterWindowOnScreen();
            Oznaka = t.Oznaka;
            Ime = t.Naziv;
            Opis = t.Opis;
            Slika = t.Slika;
            pomocni = new Tip(t.Oznaka, t.Naziv, t.Opis, t.Slika);
            this.DataContext = this;
            MainWindow.tipovi.Remove(t);
        }

        private void OdustaniButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.tipovi.Add(pomocni);
            this.Close();
        }

        private void SacuvajButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Tip t in MainWindow.tipovi)
            {
                if (t.Oznaka == OznakaTxt.Text)
                {
                    MessageBox.Show("Tip sa tom oznakom već postoji!", "Unos novog tipa");
                    return;
                }

            }

            if (OznakaTxt.Text == "" || ImeTxt.Text == "")
            {
                MessageBox.Show("Morate uneti oznaku i ime tipa!", "Izmena tipa");
                return;
            }

            Tip tip = new Tip(oznaka, ime, opis, slika);
            MainWindow.tipovi.Add(tip);

            MessageBox.Show("Uspešno ste izmenili tip!", "Izmena tipa");         
            this.Close();
        }

        private void OdaberiIkonicuButton_Click(object sender, RoutedEventArgs e)
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
