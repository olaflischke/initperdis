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
        private BummlerViewModel bummlerViewModel;

        public Bummler()
        {

        }

        public Bummler(BummlerViewModel bummlerViewModel)
        {
            this.bummlerViewModel = bummlerViewModel;
        }

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
            try
            {
                double erg = await Task.Run(() => Wurzelsumme(2000000000));
                return "Fertig mit Bummeln";
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler im BummelnAsync", ex);
                //return $"Bummeln fehlgeschlagen: {ex.Message}";
            }
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
                //Trace.WriteLine(result);
                //if (i == 123456798)
                //{
                //    throw new Exception("Exception geworfen");
                //}

                if (i % 100 == 0)
                {
                    this.bummlerViewModel.BummelMeldung = $"{result:#,##0.000}";
                }
            }

            return result;
        }
    }
}
