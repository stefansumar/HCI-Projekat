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
    /// Interaction logic for PrikazEtiketa.xaml
    /// </summary>
    public partial class PrikazEtiketa : Window
    {
        
        public PrikazEtiketa()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            dataGrid.ItemsSource = UnosEtikete.etikete;
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

        private void ZatvoriButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            UnosEtikete unesiEtiketu = new UnosEtikete();
            unesiEtiketu.Show();
        }

        private void ObrisiButton_Click(object sender, RoutedEventArgs e)
        {
            UnosEtikete.etikete.Remove((Model.Etiketa)dataGrid.SelectedItem);
        }

        private void IzmeniButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati etiketu koju želite da izmenite!", "Prikaz etiketa");
                return;
            }
            else
            {
                IzmenaEtikete izmena = new IzmenaEtikete((Etiketa)dataGrid.SelectedItem);
                izmena.ShowDialog();

            }
        }
    }
}
