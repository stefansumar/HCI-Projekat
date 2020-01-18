using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Model
{
    [Serializable()]
    public class Etiketa: INotifyPropertyChanged, ISerializable
    {
        private string oznaka;
        private string opis;
        private Color boja;

        public Etiketa()
        {
            oznaka = "";
            opis = "";
            
        }

        public Etiketa(string oznaka, string opis, Color boja)
        {
            this.oznaka = oznaka;
            this.opis = opis;
            this.boja = boja;
        }

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
            info.AddValue("Opis", Opis);
            info.AddValue("Boja", Boja);
            
        }

        public Etiketa(SerializationInfo info, StreamingContext context)
        {
            Oznaka = (string)info.GetValue("Oznaka", typeof(string));
            Opis = (string)info.GetValue("Opis", typeof(string));
            Boja = (Color)info.GetValue("Boja", typeof(Color));
        }

    }
}
