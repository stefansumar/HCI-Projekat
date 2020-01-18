using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;

namespace HCI_projekat.Model
{
    [Serializable()]
    public class Vrsta : INotifyPropertyChanged, ISerializable
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

        public string oznaka = "";
        public string naziv = "";
        public string opis = "";
        private string tip = "";
        public string statusUgrozenosti = "";
        public string slika;
        public bool opasnaPoLjude = false;
        public bool naCrvenojListi = false;
        public bool ziviUNaseljenomMestu = false;
        public string turistickiStatus = "";
        public string godisnjiPrihod = "";
        public DateTime datumOtkrivanja = DateTime.Today;
        public ObservableCollection<Etiketa> etiketeVrste = new ObservableCollection<Etiketa>();
        
        

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

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                if (value != naziv)
                {
                    naziv = value;
                    OnPropertyChanged("Naziv");
                }
            }
        }

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

        public string Tip
        {
            get
            {
                return tip;
            }
            set
            {
                if (value != tip)
                {
                    tip = value;
                    OnPropertyChanged("Tip");
                }
            }
        }

        /*private Tip tipVrste;
        public Tip TipVrste
        {
            get { return tipVrste; }

            set
             {
                if (value != tipVrste)
                {
                    tipVrste = value;
                    OnPropertyChanged("TipVrste");
                }
            }
        }*/

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

        public string StatusUgrozenosti
        {
            get
            {
                return statusUgrozenosti;
            }

            set
            {
                if (value != statusUgrozenosti)
                {
                    statusUgrozenosti = value;
                    OnPropertyChanged("StatusUgrozenosti");
                }
            }
        }

        public bool OpasnaPoLjude
        {
            get
            {
                return opasnaPoLjude;
            }

            set
            {
                if (value != opasnaPoLjude)
                {
                    opasnaPoLjude = value;
                    OnPropertyChanged("OpasnaPoLjude");
                }
            }
        }

        public bool NaCrvenojListi
        {
            get
            {
                return naCrvenojListi;
            }

            set
            {
                if (value != naCrvenojListi)
                {
                    naCrvenojListi = value;
                    OnPropertyChanged("NaCrvenojListi");
                }
            }
        }

        public bool ZiviUNaseljenomMestu
        {
            get
            {
                return ziviUNaseljenomMestu;
            }

            set
            {
                if (value != ziviUNaseljenomMestu)
                {
                    ziviUNaseljenomMestu = value;
                    OnPropertyChanged("ZiviUNaseljenomMestu");
                }
            }
        }
      
        public string TuristickiStatus
        {
            get
            {
                return turistickiStatus;
            }

            set
            {
                if (value != turistickiStatus)
                {
                    turistickiStatus = value;
                    OnPropertyChanged("TuristickiStatus");
                }
            }
        }

        public string GodisnjiPrihod
        {
            get
            {
                return godisnjiPrihod;
            }

            set
            {
                if (value != godisnjiPrihod)
                {
                    godisnjiPrihod = value;
                    OnPropertyChanged("GodisnjiPrihod");
                }
            }
        }

       
        public DateTime Datum
        {
            get { return datumOtkrivanja; }

            set
            {
                if (value != datumOtkrivanja)
                {
                    datumOtkrivanja = value;
                    OnPropertyChanged("Datum");
                }
            }
        }

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

        private double x = -1;
        private double y = -1;


        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if (value != x)
                    x = value;
                OnPropertyChanged("X");
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value != y)
                    y = value;
                OnPropertyChanged("Y");
            }
        }

        

        public Vrsta()
        {
            oznaka = "";
            naziv = "";
            opis = "";
            statusUgrozenosti = "";
            opasnaPoLjude = false;
            naCrvenojListi = false;
            ziviUNaseljenomMestu = false;
            turistickiStatus = "";
            godisnjiPrihod = "";
            datumOtkrivanja = DateTime.Today;
            etiketeVrste = new ObservableCollection<Etiketa>();
           
    }

    // Konstruktor sa parametrima
        public Vrsta(string oznaka, string naziv, string opis, string tip, string statusUgrozenosti, string slika, bool opasna, bool crvenaLista, bool ziviUNaseljenom, string turistickiStatus, string prihod, DateTime datum, ObservableCollection<Etiketa> etikete)
        {
            this.oznaka = oznaka;
            this.naziv = naziv;
            this.opis = opis;
            this.Tip = tip;
            this.statusUgrozenosti = statusUgrozenosti;
            this.slika = slika;
            this.opasnaPoLjude = opasna;
            this.naCrvenojListi = crvenaLista;
            this.ziviUNaseljenomMestu = ziviUNaseljenom;
            this.turistickiStatus = turistickiStatus;
            this.godisnjiPrihod = prihod;
            this.datumOtkrivanja = datum;
            this.etiketeVrste = etikete;
        }


        public void OnPropertyChanged(string nazivPropertija)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nazivPropertija));
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Oznaka", Oznaka);
            info.AddValue("Naziv", Naziv);
            info.AddValue("Opis", Opis);
            info.AddValue("Tip", Tip);
            info.AddValue("Slika", Slika);
            info.AddValue("OpasnaPoLjude", OpasnaPoLjude);
            info.AddValue("NaCrvenojListi", NaCrvenojListi);
            info.AddValue("ZiviUNaseljenomMestu", ZiviUNaseljenomMestu);
            info.AddValue("TuristickiStatus", TuristickiStatus);
            info.AddValue("GodisnjiPrihod", GodisnjiPrihod);
            info.AddValue("Datum", Datum);
           // info.AddValue("EtiketeVrste", EtiketeVrste);
            info.AddValue("X", X);
            info.AddValue("Y", Y);

        }

        public Vrsta(SerializationInfo info, StreamingContext context)
        {
            Oznaka = (string)info.GetValue("Oznaka", typeof(string));
            Naziv = (string)info.GetValue("Naziv", typeof(string));
            Opis = (string)info.GetValue("Opis", typeof(string));
            Slika = (string)info.GetValue("Slika", typeof(string));
            OpasnaPoLjude = (bool)info.GetValue("OpasnaPoLjude", typeof(bool));
            NaCrvenojListi = (bool)info.GetValue("NaCrvenojListi", typeof(bool));
            ZiviUNaseljenomMestu = (bool)info.GetValue("ZiviUNaseljenomMestu", typeof(bool));
            TuristickiStatus = (string)info.GetValue("TuristickiStatus", typeof(string));
            GodisnjiPrihod = (string)info.GetValue("GodisnjiPrihod", typeof(string));
            Datum = (DateTime)info.GetValue("Datum", typeof(DateTime));
           // EtiketeVrste = (ObservableCollection<Etiketa>)info.GetValue("EtiketeVrste", typeof(ObservableCollection<Etiketa>));
            X = (double)info.GetValue("X", typeof(double));
            Y = (double)info.GetValue("Y", typeof(double));
        }
    }

   
}
