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
    /// Interaction logic for TutorijalEtiketa.xaml
    /// </summary>
    public partial class TutorijalEtiketa : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
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

        public TutorijalEtiketa()
        {
            InitializeComponent();
            formaOznaka.Visibility = Visibility.Hidden;
            OpisPanel.Visibility = Visibility.Hidden;
            ColorPanel.Visibility = Visibility.Hidden;
            
            
            
        }

        private void PokreniButton_Click(object sender, RoutedEventArgs e)
        {
            pokreniPanel.Visibility = Visibility.Hidden;
            formaOznaka.Visibility = Visibility.Visible;
            OpisTxt.IsEnabled = false;
            ColorPicker.IsEnabled = false;
            Oznaka = OznakaTxt.Text;

        }

        private void NazadButton_Click(object sender, RoutedEventArgs e)
        {
            formaOznaka.Visibility = Visibility.Hidden;
            pokreniPanel.Visibility = Visibility.Visible;
        }

        private void OdustaniButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NazadButtonOpis_Click(object sender, RoutedEventArgs e)
        {
            OpisPanel.Visibility = Visibility.Hidden;
            formaOznaka.Visibility = Visibility.Visible;
        }

        private void DaljeButtonOpis_Click(object sender, RoutedEventArgs e)
        {
            OpisPanel.Visibility = Visibility.Hidden;
            ColorPanel.Visibility = Visibility.Visible;
            OznakaTxtOpisColor.IsEnabled = false;
            OpisTxtOpisColor.IsEnabled = false;
            OznakaTxtOpisColor.Text = Oznaka;
            Opis = OpisTxtOpis.Text;
            OpisTxtOpisColor.Text = Opis;
        }

        private void DaljeButton_Click_1(object sender, RoutedEventArgs e)
        {
               
            if (OznakaTxt.Text == "")
            {
                MessageBox.Show("Morate uneti oznaku etikete!", "Unos nove etikete - Tutorijal");
                return;
            }
            else
            {
                Oznaka = OznakaTxt.Text;
                OznakaTxtOpis.Text = Oznaka;
            }

            formaOznaka.Visibility = Visibility.Hidden;
            OpisPanel.Visibility = Visibility.Visible;
            OznakaTxtOpis.IsEnabled = false;
            ColorPickerOpis.IsEnabled = false;
        }

        private void NazadButtonColor_Click(object sender, RoutedEventArgs e)
        {
            ColorPanel.Visibility = Visibility.Hidden;
            OpisPanel.Visibility = Visibility.Visible;

        }

        private void ZavrsiButtonColor_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
