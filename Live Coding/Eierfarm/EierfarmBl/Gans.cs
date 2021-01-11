using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Gans : Gefluegel
    {
        public Gans():base("Neue Gans")
        {
            this.Gewicht = 2500;
        }

        public override void EiLegen()
        {
            throw new NotImplementedException();
        }

        public override void Fressen()
        {
            throw new NotImplementedException();
        }
    }
}
