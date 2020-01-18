using HCI_projekat.Dijalozi;
using HCI_projekat.Help;
using HCI_projekat.Model;
using Microsoft.Win32;
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
    /// Interaction logic for UnosVrste.xaml
    /// </summary>
    public partial class UnosVrste : Window , INotifyPropertyChanged
    {
        
        public UnosVrste()
        {
            InitializeComponent();
            this.DataContext = this;
            CenterWindowOnScreen();

            StatusUgrozenosti = new ObservableCollection<string>();
            StatusUgrozenosti.Add("Kritično ugrožena");
            StatusUgrozenosti.Add("Ugrožena");
            StatusUgrozenosti.Add("Ranjiva");
            StatusUgrozenosti.Add("Zavisno od očuvanja staništa");
            StatusUgrozenosti.Add("Blizu rizika");
            StatusUgrozenosti.Add("Najmanjeg rizika");
            Ugrozenost_ComboBox.ItemsSource = StatusUgrozenosti;

            TuristickiStatus = new ObservableCollection<string>();
            TuristickiStatus.Add("Izolovana");
            TuristickiStatus.Add("Delimično habituirana");
            TuristickiStatus.Add("Habituirana");
            TuristickiStatus_ComboBox.ItemsSource = TuristickiStatus;

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
            get
            {
                return oznaka;
            }

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
            get
            {
                return ime;
            }

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
            get
            {
                return opis;
            }

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
            get
            {
                return slika;
            }

            set
            {
                if (value != slika)
                {
                    slika = value;
                    OnPropertyChanged("Slika");
                }
            }
        }

        private Tip tip;
        public Tip Tip
        {
            get { return tip;  }

            set
            {
                if (value != tip)
                {
                    tip = value;
                    OnPropertyChanged("Tip");
                }
            }
        }

        private string oznakaTipa;
        public string OznakaTipa
        {
            get
            {
                return oznakaTipa;
            }

            set
            {
                if (value != oznakaTipa)
                {
                    oznakaTipa = value;
                    OnPropertyChanged("OznakaTipa");
                }
            }
        }

        public ObservableCollection<string> StatusUgrozenosti
        {
            get;
            set;
        }

        public ObservableCollection<string> TuristickiStatus
        {
            get;
            set;
        }

        private string prihod;
        public string Prihod
        {
            get
            {
                return prihod;
            }

            set
            {
                if (value != prihod)
                {
                    prihod = value;
                    OnPropertyChanged("Prihod");
                }
            }
        }

        private DateTime datum;
        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                if (value != datum)
                {
                    datum = value;
                    OnPropertyChanged("Datum");
                }
            }
        }

        private ObservableCollection<Etiketa> etiketeVrste = new ObservableCollection<Etiketa>();
        public ObservableCollection<Etiketa> EtiketeVrste
        {
            get { return etiketeVrste; }

            set
            {
                if (value != etiketeVrste)
                {
                    etiketeVrste = value;
                    OnPropertyChanged("EtiketeVrste");
                }
            }
        }

        private bool opasna;
        public bool Opasna
        {
            get { return opasna; }

            set
            {
                if (value != opasna)
                {
                    opasna = value;
                    OnPropertyChanged("Opasna");
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

        private void Sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            foreach(Vrsta v in MainWindow.vrste)
            {
                if (v.Oznaka == OznakaTxt.Text)
                {
                    MessageBox.Show("Vrsta sa tom oznakom već postoji!", "Unos nove vrste");
                    return;
                }

                if (v.Naziv == ImeTxt.Text)
                {
                    MessageBox.Show("Vrsta sa tim nazivom već postoji!", "Unos nove vrste");
                    return;
                }
            }

            if (ImeTxt.Text == "" || OznakaTxt.Text == "" || TipTxt.Text == "")
            {
                System.Windows.MessageBox.Show("Morate uneti oznaku, ime i tip vrste!", "Dodavanje nove vrste");
                return;
            }
            DateTime d = datum;


            opasna = false;
            bool iucn = false;
            bool naseljeno = false;

            if ((bool)OpasnaDa.IsChecked)
            {
                opasna = true;
            }

            if ((bool)IUCNDa.IsChecked)
            {
                iucn = true;
            }

            if ((bool)NaseljenoDa.IsChecked)
            {
                naseljeno = true;
            }

            String statusUgrozenosti = "";
            if (Ugrozenost_ComboBox.SelectedIndex.Equals(-1))
            {
                statusUgrozenosti = "";
            }
            else if (Ugrozenost_ComboBox.SelectedItem.Equals("Kritično ugrožena"))
            {
                int index = StatusUgrozenosti.IndexOf("Kritično ugrožena");
                statusUgrozenosti = StatusUgrozenosti[index];
            }
            else if (Ugrozenost_ComboBox.SelectedItem.Equals("Ugrožena"))
            {
                int index = StatusUgrozenosti.IndexOf("Ugrožena");
                statusUgrozenosti = StatusUgrozenosti[index];
            }
            else if (Ugrozenost_ComboBox.SelectedItem.Equals("Ranjiva"))
            {
                int index = StatusUgrozenosti.IndexOf("Ranjiva");
                statusUgrozenosti = StatusUgrozenosti[index];
            }
            else if (Ugrozenost_ComboBox.SelectedItem.Equals("Zavisno od očuvanja staništa"))
            {
                int index = StatusUgrozenosti.IndexOf("Zavisno od očuvanja staništa");
                statusUgrozenosti = StatusUgrozenosti[index];
            }
            else if (Ugrozenost_ComboBox.SelectedItem.Equals("Blizu rizika"))
            {
                int index = StatusUgrozenosti.IndexOf("Blizu rizika");
                statusUgrozenosti = StatusUgrozenosti[index];
            }
            else if (Ugrozenost_ComboBox.SelectedItem.Equals("Najmanjeg rizika"))
            {
                int index = StatusUgrozenosti.IndexOf("Najmanjeg rizika");
                statusUgrozenosti = StatusUgrozenosti[index];
            }

            String turistickiStatus = "";

            if (TuristickiStatus_ComboBox.SelectedIndex.Equals(-1))
            {
                turistickiStatus = "";
            }
            else if (TuristickiStatus_ComboBox.SelectedItem.Equals("Izolovana"))
            {
                int index = TuristickiStatus.IndexOf("Izolovana");
                turistickiStatus = TuristickiStatus[index];
            }
            else if (TuristickiStatus_ComboBox.SelectedItem.Equals("Delimično habituirana"))
            {
                int index = TuristickiStatus.IndexOf("Delimično habituirana");
                turistickiStatus = TuristickiStatus[index];
            }
            else if (TuristickiStatus_ComboBox.SelectedItem.Equals("Habituirana"))
            {
                int index = TuristickiStatus.IndexOf("Habituirana");
                turistickiStatus = TuristickiStatus[index];
            }

            datum = (DateTime) Datum_DataPicker.SelectedDate;
            Vrsta vrsta = new Vrsta(oznaka, ime, opis, oznakaTipa, statusUgrozenosti, slika, opasna, iucn, naseljeno, turistickiStatus, prihod, datum, etiketeVrste);
            MainWindow.vrste.Add(vrsta);

            System.Windows.MessageBox.Show("Uspešno ste uneli novu vrstu!", "Dodavanje nove vrste");
            this.Close();
        }

        private void OdaberiTip_Click(object sender, RoutedEventArgs e)
        {
            OdabirTipa odaberiTip = new OdabirTipa();
            odaberiTip.ShowDialog();

            tip = odaberiTip.Selektovan;
            if (tip != null)
            {
               
                OznakaTipa = tip.Oznaka;
                TipTxt.Text = OznakaTipa;
                
            }

            odaberiTip.Close();
        }

        private void DodajEtiketuButton_Click(object sender, RoutedEventArgs e)
        {
            OdabirEtikete odabir = new OdabirEtikete();
            odabir.ShowDialog();

            bool dozvoljeno = true;

            foreach (Etiketa et in etiketeVrste)
            {
                if (odabir.Selektovan.Oznaka == et.Oznaka)
                {
                    dozvoljeno = false;
                }
            }
            if (dozvoljeno)
            {
                etiketeVrste.Add(odabir.Selektovan);
            }
            else {
                MessageBox.Show("Vrsta vec sadrzi odabranu etiketu!", "Unos vrste");

            }
            odabir.Close();
        }

        private void UkloniEtiketuButton_Click(object sender, RoutedEventArgs e)
        {
            if ((Etiketa)EtiketeListView.SelectedItem != null)
            {
                etiketeVrste.Remove((Etiketa)EtiketeListView.SelectedItem);
            }
            else
            {
                MessageBox.Show("Morate odabrati etiketu koju želite da uklonite!", "Dodavanje vrste");
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            IInputElement focusedControl = FocusManager.GetFocusedElement(Application.Current.Windows[0]);
            if (focusedControl is DependencyObject)
            {
                string str = HelpProvider.GetHelpKey((DependencyObject)focusedControl);
                HelpProvider.ShowHelp(str, this);
            }
        }


    }


}
