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
    /// Interaction logic for OdabirEtikete.xaml
    /// </summary>
    public partial class OdabirEtikete : Window
    {
        public OdabirEtikete()
        {
            InitializeComponent();
            OdaberiEtiketuDataGrid.ItemsSource = UnosEtikete.etikete;
            this.DataContext = this;
        }

        private Etiketa selektovana;
        public Etiketa Selektovan
        {
            get { return selektovana; }
            set { selektovana = value; }
        }

        

        private void OdaberiButton_Click(object sender, RoutedEventArgs e)
        {
            if (OdaberiEtiketuDataGrid.SelectedItem != null)
            {
                selektovana = (Etiketa)OdaberiEtiketuDataGrid.SelectedItem;
                
            }
            else
            {
                selektovana = null;
                MessageBox.Show("Morate odabrati etiketu!", "Odbir etikete");
                return;
            }

            
            this.Close();
        }

        private void OdustaniButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
