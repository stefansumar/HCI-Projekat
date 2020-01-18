using HCI_projekat.Model;
using HCI_projekat.Unos;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for PrikazTipova.xaml
    /// </summary>
    public partial class PrikazTipova : Window
    {

        //private string selected = "";
        public PrikazTipova()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            dataGrid.ItemsSource = MainWindow.tipovi;
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            if (dataGrid.SelectedItem == null)
            {
                MessageBox.Show("Morate odabrati tip koji želite da obrišete!", "Brisanje tipa");
            }
            else
            {
                if (MessageBox.Show("Da li ste sigurni da želite da obrišete tip?", "Brisanje tipa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Tip temp = (Tip)dataGrid.SelectedItem;
                    Vrsta tempV = new Vrsta();
                    foreach (Vrsta v in MainWindow.vrste)
                    {
                        if (temp.Oznaka == v.Tip)
                        {
                            tempV = v;
                        }
                    }
                    MainWindow.vrste.Remove(tempV);
                    MainWindow.tipovi.Remove((Tip)dataGrid.SelectedItem);

                }
                else
                {
                    return;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UnosTipaVrste unosTipaVrste = new UnosTipaVrste();
            unosTipaVrste.ShowDialog();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
               
        }

        private void ZatvoriButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void IzmeniButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (dataGrid.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati tip koji želite da izmenite!", "Prikaz tipova");
                return;
            }
            else
            {
                IzmenaTipa izmena = new IzmenaTipa((Tip)dataGrid.SelectedItem);
                izmena.ShowDialog();
                
            }


        }
    }
}

/* <DataGridTextColumn Header="Oznaka" Binding="{Binding Oznaka}" Width="4*" />
                <DataGridTextColumn Header="Naziv" Binding="{Binding Naziv}" Width="4*" />
                <DataGridTextColumn Header="Opis" Binding="{Binding Opis}" Width="4*" />
                <DataGridTextColumn Header="Ikonica" Binding="{Binding Slika}" Width="4*"/>
*/