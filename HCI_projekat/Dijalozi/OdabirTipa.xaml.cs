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
    /// Interaction logic for OdabirTipa.xaml
    /// </summary>
    public partial class OdabirTipa : Window
    {
        private Tip selektovan;
        public Tip Selektovan
        {
            get { return selektovan; }
            set { selektovan = value; }
        }

        public OdabirTipa()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            dataGrid.ItemsSource = MainWindow.tipovi;
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

        public void Odaberi_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                selektovan = (Tip) dataGrid.SelectedItem;
            }
            else
            {
                selektovan = null;
                
            }

            this.Close();

            

            

        }
    }

    
}
