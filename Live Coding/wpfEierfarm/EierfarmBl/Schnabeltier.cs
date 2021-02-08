using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public class Schnabeltier : Saeugetier, IEiLeger, IFresser
    {
        public ObservableCollection<Ei> Eier { get; set; } = new ObservableCollection<Ei>();

        public double Gewicht { get; set; }


        public event EventHandler<GefluegelEventArgs> EigenschaftGeaendert;

        public void EiLegen()
        {
            if (this.Gewicht>1500)
            {
                Ei ei = new Ei(this);
                this.Eier.Add(ei);
                this.Gewicht -= ei.Gewicht;
            }
        }

        public void Fressen()
        {
            if (this.Gewicht<4500)
            {
                this.Gewicht += 250;
            }
        }

        public override void Saeugen()
        {
            throw new NotImplementedException();
        }
    }
}