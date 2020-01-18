using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace HCI_projekat.Model
{
    [Serializable()]
    public class Tip : INotifyPropertyChanged, ISerializable
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

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
            info.AddValue("Slika", Slika);
        }

        public Tip(SerializationInfo info, StreamingContext context)
        {
            Oznaka = (string)info.GetValue("Oznaka", typeof(string));
            Naziv = (string)info.GetValue("Naziv", typeof(string));
            Opis = (string)info.GetValue("Opis", typeof(string));
            Slika = (string)info.GetValue("Slika", typeof(string));
        }

        private string oznaka = "";
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

        private string naziv = "";
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

        private string opis = "";
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

        private string slika = "";
        public string Slika
        {
            get { return slika;  }

            set
            {
                if (value != slika)
                {
                    slika = value;
                    OnPropertyChanged("Slika");
                }
            }
        }

        public Tip(){ }

        public Tip(string oznaka, string naziv, string opis, string slika)
        {
            this.oznaka = oznaka;
            this.naziv = naziv;
            this.opis = opis;
            this.slika = slika;
        }

    }

}
