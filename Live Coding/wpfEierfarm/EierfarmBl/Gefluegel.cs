using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EierfarmBl
{
    public abstract class Gefluegel : IEiLeger, IFresser, INotifyPropertyChanged
    {
        public Gefluegel(string name)
        {
            this.Name = name;
        }

        public event EventHandler<GefluegelEventArgs> EigenschaftGeaendert;
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnEigenschaftGeaendert([CallerMemberName] string propName = "")
        {
            if (EigenschaftGeaendert != null)
            {
                EigenschaftGeaendert(this, new GefluegelEventArgs(propName));
            }
        }

        private void OnPropertyChanged([CallerMemberName]string property="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public Guid Id { get;  set; } = Guid.NewGuid();

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnEigenschaftGeaendert();
                OnPropertyChanged();
            }
        }


        public ObservableCollection<Ei> Eier { get; set; } = new ObservableCollection<Ei>();

        public int Haltungsform { get; set; }
        public EiFarbe Farbindikator { get;  set; }

        private double gewicht;
        public double Gewicht
        {
            get
            {
                return gewicht;
            }
            set
            {
                gewicht = value;
                OnEigenschaftGeaendert();
                OnPropertyChanged();
            }
        }
        public DateTime Schluepfdatum { get;  set; }

        public abstract void Fressen();
        public abstract void EiLegen();
    }
}