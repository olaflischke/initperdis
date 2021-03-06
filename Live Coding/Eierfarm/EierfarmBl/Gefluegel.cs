﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace EierfarmBl
{
    public abstract class Gefluegel : IEiLeger, IFresser
    {
        public Gefluegel(string name)
        {
            this.Name = name;
        }

        public event EventHandler<GefluegelEventArgs> EigenschaftGeaendert;

        private void OnEigenschaftGeaendert([CallerMemberName] string propName = "")
        {
            if (EigenschaftGeaendert != null)
            {
                EigenschaftGeaendert(this, new GefluegelEventArgs(propName));
            }
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
            }
        }
        public DateTime Schluepfdatum { get;  set; }

        public abstract void Fressen();
        public abstract void EiLegen();
    }
}