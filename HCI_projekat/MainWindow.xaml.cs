using HCI_projekat.Dijalozi;
using HCI_projekat.Unos;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using HCI_projekat.Model;

namespace HCI_projekat
{
    
    public partial class MainWindow : INotifyPropertyChanged
    {
        public static ObservableCollection<Model.Vrsta> vrste = new ObservableCollection<Vrsta>();
        public static ObservableCollection<Model.Tip> tipovi = new ObservableCollection<Tip>();
        public static ObservableCollection<Vrsta> vrsteNaMapi;

        private Point startPoint;
        private Vrsta selektovanaVrsta;
        public Vrsta SelektovanaVrsta
        {
            get { return selektovanaVrsta; }
            set
            {
                if (value != selektovanaVrsta)
                {
                    selektovanaVrsta = value;
                    OnPropertyChanged("SelektovanaVrsta");
                }
            }
        }

        public ObservableCollection<Model.Vrsta> Vrste
        {
            get { return vrste; }
            set
            {
                if (value != vrste)
                {
                    vrste = value;
                    OnPropertyChanged("Vrste");
                }
            }
        }

        public ObservableCollection<Model.Tip> Tipovi
        {
            get; set;
        }
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            CenterWindowOnScreen();
            ucitajPodatke();
        }


        private Etiketa findTagById(string uid)
        {
            foreach (var tag in UnosEtikete.etikete)
            {
                if (tag.Oznaka == uid)
                {
                    return tag;
                }
            }

            return null;
        }

        public Tip findTypeById(string uid)
        {
            foreach (var type in tipovi)
            {
                if (type.Oznaka == uid)
                {
                    return type;
                }
            }

            return null;
        }

        private void ucitajPodatke() {
            //Za tipove
            XmlSerializer deserializerTipovi = new XmlSerializer(typeof(ObservableCollection<Tip>));
            FileStream fsTipovi = File.Open(@"C:\Users\2\Downloads\HCI_projekat\HCI_projekat\HCI_projekat\Tipovi.xml", FileMode.Append);
            fsTipovi.Close();

            using (FileStream fsTipovi1 = File.OpenRead(@"C: \Users\2\Downloads\HCI_projekat\HCI_projekat\HCI_projekat\Tipovi.xml"))
            {
                if (fsTipovi1.Length != 0)
                    tipovi = (ObservableCollection<Tip>)deserializerTipovi.Deserialize(fsTipovi1);
            }

            //Za etikete
            XmlSerializer deserializerEtikete = new XmlSerializer(typeof(ObservableCollection<Etiketa>));
            FileStream fsEtikete = File.Open(@"C:\Users\2\Downloads\HCI_projekat\HCI_projekat\HCI_projekat\Etikete.xml", FileMode.Append);
            fsEtikete.Close();

            using (FileStream fsEtikete1 = File.OpenRead(@"C:\Users\2\Downloads\HCI_projekat\HCI_projekat\HCI_projekat\Etikete.xml"))
            {
                if (fsEtikete1.Length != 0)
                    UnosEtikete.etikete = (ObservableCollection<Etiketa>)deserializerEtikete.Deserialize(fsEtikete1);
            }

            //Za citanje svih vrsta
            XmlSerializer deserializerVrsta = new XmlSerializer(typeof(ObservableCollection<Vrsta>));
            FileStream fsVrsta = File.Open(@"C:\Users\2\Downloads\HCI_projekat\HCI_projekat\HCI_projekat\Vrste.xml", FileMode.Append);
            fsVrsta.Close();

            using (FileStream fsVrsta1 = File.OpenRead(@"C:\Users\2\Downloads\HCI_projekat\HCI_projekat\HCI_projekat\Vrste.xml"))
            {
                if (fsVrsta1.Length != 0)
                    vrste = (ObservableCollection<Vrsta>)deserializerVrsta.Deserialize(fsVrsta1);
            }

            /*Image img = new Image();
            //img.Source = new BitmapImage(new Uri(lokal.Ikonica));
            img.Width = 50;
            img.Height = 50;
            img.Tag = vrsta.Oznaka;
            img.MouseMove += ExistingImageMove;

            Binding myBinding = new Binding();
            myBinding.Source = findVrstaById(vrsta.Oznaka);
            myBinding.Path = new PropertyPath("Slika");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(img, Image.SourceProperty, myBinding);

            canvasMap.Children.Add(img);
            Canvas.SetLeft(img, vrsta.X - 20);
            Canvas.SetTop(img, vrsta.Y - 20);*/

            foreach (Vrsta v in vrste)
            {
                if (v.X != -1 && v.Y != -1)
                {
                    putOnMap(v, true);
                }
            }
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

        // Klikovi na MenuItems i Buttone na MainWindow
        private void UnosVrsteClick(object sender, RoutedEventArgs e)
        {
            UnosVrste unosVrste = new UnosVrste();
            unosVrste.ShowDialog();
        }

        private void UnosEtiketeClick(object sender, RoutedEventArgs e)
        {
            UnosEtikete unosEtikete = new UnosEtikete();
            unosEtikete.ShowDialog();
        }

        private void UnosTipaVrsteClick(object sender, RoutedEventArgs e)
        {
            UnosTipaVrste unosTipaVrste = new UnosTipaVrste();
            unosTipaVrste.ShowDialog();
        }

        private void IzmeniVrstuClick(object sender, RoutedEventArgs e)
        {
            IzmenaVrste izmenaVrste = new IzmenaVrste();
            izmenaVrste.ShowDialog();
        }

        private void IzmeniTipClick(object sender, RoutedEventArgs e)
        {
            IzmenaTipa izmenaTipa = new IzmenaTipa();
            izmenaTipa.ShowDialog();
        }

        private void IzmeniEtiketuClick(object sender, RoutedEventArgs e)
        {
            IzmenaEtikete izmenaEtikete = new IzmenaEtikete();
            izmenaEtikete.ShowDialog();
        }

        private void PrikaziVrsteClick(object sender, RoutedEventArgs e)
        {
            PrikazVrsta prikazVrsta = new PrikazVrsta();
            prikazVrsta.ShowDialog();
        }

        private void PrikaziTipoveClick(object sender, RoutedEventArgs e)
        {
            PrikazTipova prikazTipova = new PrikazTipova();
            prikazTipova.ShowDialog();
        }

        private void PrikaziEtiketeClick(object sender, RoutedEventArgs e)
        {
            PrikazEtiketa prikazEtiketa = new PrikazEtiketa();
            prikazEtiketa.ShowDialog();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrikazTipova prikazTipova = new PrikazTipova();
            prikazTipova.ShowDialog();
            



        }

        private void Tip_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // SERIJALIZACIJA
        private void SacuvajTipove_Button_Click(object sender, RoutedEventArgs e)
        {
            // ovde cuvas ObservableCollection<Tip> tipovi u xml fajl
            using (Stream fs = new FileStream(@"C:\Users\Stefan\Desktop\Faks\HCI\HCI-projekat\HCI_projekat\Tipovi.xml", FileMode.Create, FileAccess.Write,
                FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Tip>));
                serializer.Serialize(fs, tipovi);
            }
            

            MessageBox.Show("Uspešno ste sačuvali tipove!", "Čuvanje tipova");
        }

        private void SacuvajEtikete_Button_Click(object sender, RoutedEventArgs e)
        {
            using (Stream fs = new FileStream(@"C:\Users\Stefan\Desktop\Faks\HCI\HCI-projekat\HCI_projekat\Etikete.xml", FileMode.Create, FileAccess.Write,
                FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Etiketa>));
                serializer.Serialize(fs, UnosEtikete.etikete);
            }


            MessageBox.Show("Uspešno ste sačuvali etikete!", "Čuvanje etiketa");

        }

        private void SacuvajVrste_Button_Click(object sender, RoutedEventArgs e)
        {
            using (Stream fs = new FileStream(@"C:\Users\Stefan\Desktop\Faks\HCI\HCI-projekat\HCI_projekat\Vrste.xml", FileMode.Create, FileAccess.Write,
                FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Vrsta>));
                serializer.Serialize(fs, vrste);
            }


            MessageBox.Show("Uspešno ste sačuvali vrste!", "Čuvanje ugroženih vrsta");

        }

        private void IzadjiIzPrograma_Click(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Da li želite da sačuvate podatke?", "Izlaz", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                using (Stream fs = new FileStream(@"C:\Users\Stefan\Desktop\Faks\HCI\HCI-projekat\HCI_projekat\Vrste.xml", FileMode.Create, FileAccess.Write,
                FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Vrsta>));
                    serializer.Serialize(fs, vrste);
                    
                }

                vrste = null;

                using (Stream fs = new FileStream(@"C:\Users\Stefan\Desktop\Faks\HCI\HCI-projekat\HCI_projekat\Tipovi.xml", FileMode.Create, FileAccess.Write,
                FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Tip>));
                    serializer.Serialize(fs, tipovi);
                }

                tipovi = null;


                using (Stream fs = new FileStream(@"C:\Users\Stefan\Desktop\Faks\HCI\HCI-projekat\HCI_projekat\Etikete.xml", FileMode.Create, FileAccess.Write,
                FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Etiketa>));
                    serializer.Serialize(fs, UnosEtikete.etikete);
                }

                UnosEtikete.etikete = null;

            }
            

        }


        // DRAG & DROP
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelektovanaVrsta = listView.SelectedItem as Vrsta;
        }

        private void MapImageView_OnDragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("vrsta") || sender == e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void MapImageView_OnDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("vrsta"))
            {
                return;
            }

            Vrsta vrsta = e.Data.GetData("vrsta") as Vrsta;

            if (vrsta == null)
            {
                return;
            }

            bool result = canvasMap.Children.Cast<Image>()
                .Any(x => x.Tag != null && x.Tag.ToString() == vrsta.Oznaka);
            System.Windows.Point d0 = e.GetPosition(canvasMap);
            foreach (var lok in vrste)
            {
                if (lok.Oznaka != vrsta.Oznaka && lok.X != -1 && lok.Y != -1 && Math.Abs(lok.X - d0.X) <= 30 &&
                    Math.Abs(lok.Y - d0.Y) <= 30)
                {
                    System.Windows.MessageBox.Show("Ne može se postaviti preko druge ugrožene vrste!", "Postavljanje vrste na mapu");
                    return;
                }

            }

            if (result)
            {
                System.Windows.MessageBox.Show("Ugrožena vrsta se već nalazi na mapi!", "Postavljanje vrste na mapu");
                return;
            }

            var positionX = e.GetPosition(canvasMap).X;
            var positionY = e.GetPosition(canvasMap).Y;
            vrsta.X = positionX;
            vrsta.Y = positionY;

            putOnMap(vrsta, true);
        }

        private void putOnMap(Vrsta vrsta, bool shouldEdit)
        {
            Image img = new Image();
            //img.Source = new BitmapImage(new Uri(lokal.Ikonica));
            img.Width = 50;
            img.Height = 50;
            img.Tag = vrsta.Oznaka;
            img.MouseMove += ExistingImageMove;

            Binding myBinding = new Binding();
            myBinding.Source = findVrstaById(vrsta.Oznaka);
            myBinding.Path = new PropertyPath("Slika");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(img, Image.SourceProperty, myBinding);

            canvasMap.Children.Add(img);
            Canvas.SetLeft(img, vrsta.X - 20);
            Canvas.SetTop(img, vrsta.Y - 20);
            
        }

        private void ExistingImageMove(object sender, MouseEventArgs e)
        {
            System.Windows.Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;
            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                 Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                Image img = sender as Image;
                var oznaka = img.Tag as string;
                var lok = findVrstaById(oznaka);
                canvasMap.Children.Remove(img);
                DataObject dragData = new DataObject("vrsta", lok);
                DragDrop.DoDragDrop(img, dragData, DragDropEffects.Move);
            }
        }

        private void Icon_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void Icon_OnMouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;
            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                 Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                try
                {
                    if (selektovanaVrsta != null)
                    {
                        ListViewItem listViewItem = FindAnchestor<ListViewItem>((DependencyObject)e.OriginalSource);
                        DataObject dragData = new DataObject("vrsta", selektovanaVrsta);
                        DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        // Helper to search up the VisualTree
        private static T FindAnchestor<T>(DependencyObject current)
            where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }

        private void ListView_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                IzmenaVrste izmena = new IzmenaVrste((Vrsta)listView.SelectedItem);
                izmena.ShowDialog();
            }
            else {
                return;
            }
        }


        private void EventSetter_OnHandler(object sender, KeyEventArgs e)
        {
            /* if (e.Key == Key.Return)
             {
                 editMonument();
                 return;
             }

             if (e.Key == Key.Delete)
             {
                 deleteMonument();
                 return;
             }*/
        }
        public Vrsta findVrstaById(string uid)
        {
            foreach (var vrsta in vrste)
            {
                if (vrsta.Oznaka == uid)
                {
                    return vrsta;
                }
            }

            return null;
        }
        //
        private void loadMap()
        {
            foreach (var vrsta in vrste)
            {
                bool result = canvasMap.Children.Cast<Image>()
                    .Any(x => x.Tag != null && x.Tag.ToString() == vrsta.Oznaka);
                if (result || vrsta.X == -1 || vrsta.Y == -1)
                {
                    continue;
                }

                PutOnMap(vrsta, false);
            }
        }
        private void PutOnMap(Vrsta vrsta, bool shouldEdit)
        {
            Image img = new Image();
            //img.Source = new BitmapImage(new Uri(monument.Icon));
            img.Width = 50;
            img.Height = 50;
            img.Tag = vrsta.Oznaka;
            img.MouseMove += ExistingImageMove;

            Binding myBinding = new Binding();
            myBinding.Source = findVrstaById(vrsta.Oznaka);
            myBinding.Path = new PropertyPath("Ikonica");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(img, Image.SourceProperty, myBinding);

            canvasMap.Children.Add(img);
            Canvas.SetLeft(img, vrsta.X - 20);
            Canvas.SetTop(img, vrsta.Y - 20);
            if (shouldEdit)
            {
                //DataStore.getInstance().editMonument(monument, monument.Uid);
            }
        }

        private void EtiketaTutorijalMI_Click(object sender, RoutedEventArgs e)
        {
            TutorijalEtiketa tutorijal = new TutorijalEtiketa();
            tutorijal.ShowDialog();
        }

        private void ObrisiButton_Click(object sender, RoutedEventArgs e)
        {
            Vrsta v = (Vrsta)listView.SelectedItem;
            Image selektovana = new Image();

            foreach (Image img in canvasMap.Children.OfType<Image>())
            {
                if (v.Oznaka.Equals(img.Tag))
                {
                    selektovana = img;
                }
            }
            canvasMap.Children.Remove(selektovana);
            vrste.Remove(v);
        }
    }
}
