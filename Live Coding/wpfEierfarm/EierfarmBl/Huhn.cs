using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Huhn : Gefluegel
    {
        private Huhn():base("Neues Huhn")
        {

        }

        public Huhn(string name) : base(name)
        {
            this.Gewicht = 1000;
            this.Schluepfdatum = DateTime.Now.AddDays(-180);
            this.Farbindikator = (EiFarbe)(new Random()).Next(Enum.GetNames(typeof(EiFarbe)).Count()); // DirectCast, Exception, wenn Cast fehlschlägt.
        }
        
        public override void EiLegen()
        {
            if (this.Gewicht > 1500)
            {
                Ei ei = new Ei(this);
                this.Gewicht -= ei.Gewicht;
                this.Eier.Add(ei);
            }
        }

        public override void Fressen()
        {
            if (this.Gewicht < 3000)
            {
                // this.Gewicht = this.Gewicht + 100;
                this.Gewicht += 100;
            }
        }
    }
}
