using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BummlerApp
{
    public class Bummler
    {
        public string Bummeln()
        {
            double erg = Wurzelsumme(2000000000);
            return "Fertig mit Bummeln";
        }

        public string Troedeln()
        {
            double erg = Wurzelsumme(4000000000);
            return "Fertig mit Trödeln";
        }

        public async Task<string> BummelnAsync()
        {
            double erg = await Task.Run(() => Wurzelsumme(2000000000));
            return "Fertig mit Bummeln";
        }

        public async Task<string> TroedelnAsync()
        {
            double erg = await Task.Run(() => Wurzelsumme(4000000000));
            return "Fertig mit Trödeln";
        }


        private double Wurzelsumme(Int64 max)
        {
            double result = 0;



            for (Int64 i = 0; i < max; i++)
            {
                result += Math.Sqrt(i);
                Trace.WriteLine(result);
            }

            return result;
        }
    }
}
