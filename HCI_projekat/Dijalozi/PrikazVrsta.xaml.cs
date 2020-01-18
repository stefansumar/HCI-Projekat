using HCI_projekat.Model;
using HCI_projekat.Unos;
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

namespace HCI_projekat.Dijalozi
{
    /// <summary>
    /// Interaction logic for PrikazVrsta.xaml
    /// </summary>
    public partial class PrikazVrsta : Window, INotifyPropertyChanged
    {
        private static ObservableCollection<Vrsta> vrste;
        public ObservableCollection<Vrsta> Vrste
        {
            get { return vrste; }
            set { vrste = value; }
        }

        public PrikazVrsta()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            dataGrid.ItemsSource = MainWindow.vrste;
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

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string uidFilter;

        public event PropertyChangedEventHandler PropertyChanged;

        public string UidFilter
        {
            get { return uidFilter; }
            set
            {
                if (value != uidFilter)
                {
                    uidFilter = value;
                    OnPropertyChanged("UidFilter");
                }
            }
        }


        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            this.Close();
        }

        private void DodajNovuVrstu_Click(object sender, RoutedEventArgs e)
        {
            UnosVrste unosVrste = new UnosVrste();
            unosVrste.ShowDialog();
        }

        private void IzmeniButton_Click(object sender, RoutedEventArgs e)
        {

            if (dataGrid.SelectedItem != null)
            {
                IzmenaVrste izmeni = new IzmenaVrste((Vrsta)dataGrid.SelectedItem);
                izmeni.ShowDialog();
            }
            else
            {
                MessageBox.Show("Morate odabrati vrstu koju želite da izmenite!", "Izmena vrste");
                return;
            }
            
        }

        private void Button_Obrisi_Click(object sender, RoutedEventArgs e)
        {
            Vrsta v = null;
            if (dataGrid.SelectedValue != null)
            {
                if (MessageBox.Show("Da li ste sigurni da želite da obrišete vrstu?", "Brisanje vrste", MessageBoxButton.YesNo) == MessageBoxResult.No)
                {
                    return;
                }
                else
                {
                    v = (Vrsta)dataGrid.SelectedItem;
                    MainWindow.vrste.Remove(v);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Niste odabrali vrstu koju želite da obrišete!", "Brisanje vrste");
            }
        }

        private void OcistiPretraguButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }

        private void izvrsiPretragu(string tekst)
        {
            ICollectionView cv = CollectionViewSource.GetDefaultView(MainWindow.vrste);
            if (string.IsNullOrEmpty(tekst))
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    Vrsta vrsta = o as Vrsta;
                    string[] words = tekst.Split(' ');
                    if (words.Contains(""))
                        words = words.Where(word => word != "").ToArray();
                    return words.Any(word => vrsta.Tip.ToUpper().Contains(word.ToUpper()));
                };

                dataGrid.ItemsSource = MainWindow.vrste; 
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tekstPolje = sender as System.Windows.Controls.TextBox;
            izvrsiPretragu(tekstPolje.Text);
        }


        private void Izadji(object sender, CancelEventArgs e)
        {
            textBox.Text = "";
            
        }
    }
}


/*<DataGridTextColumn Header="Oznaka" Binding="{Binding Oznaka}" Width="3*" />
                <DataGridTextColumn Header="Ime" Binding="{Binding Naziv}" Width="3*" />
                <DataGridTextColumn Header="Opis" Binding="{Binding Path = Opis, UpdateSourceTrigger=PropertyChanged}" Width="3*" />
                <DataGridTextColumn Header="Tip" Binding="{Binding Tip}" Width="3*" />
                <DataGridTextColumn Header="Status ugroženosti" Binding="{Binding StatusUgrozenosti}" Width="3*" />
                <DataGridCheckBoxColumn Header="Opasna po ljude"  Binding="{Binding Path=Opasna, UpdateSourceTrigger=PropertyChanged}" Width="3*"/>
                <DataGridCheckBoxColumn Header="IUCN" Width="3*"/>
                <DataGridCheckBoxColumn Header="Živi u naseljenom regionu" Width="3*"/>
                <DataGridTextColumn Header="Turistički status" Binding="{Binding TuristickiStatus}" Width="3*" />
                <DataGridTextColumn Header="Prihod" Binding="{Binding Path=Prihod, UpdateSourceTrigger=PropertyChanged}" Width="3*" />
                <DataGridTextColumn Header="Datum" Binding="{Binding Datum, StringFormat=\{0:dd.MM.yyyy\}}" Width="3*"/>*/
