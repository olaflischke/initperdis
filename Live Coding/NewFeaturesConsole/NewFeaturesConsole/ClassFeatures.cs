using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace NewFeaturesConsole
{
    public class ClassFeatures
    {
        // Auto-Property Initializer ohne set (neu in C# 6)
        public string Name { get; } = "ClassFeatures";

        // Expression Bodied Members (neu in C# 6)
        public string GetBirthDate() => "Gestern";

        private DateTime? _date;
        public DateTime? Date { get => _date; set => _date = value; }

        public void Samples()
        {
            // Verbatim String Concatination (neu in C# 6)
            string s = $"{this.Name}: {this.Date:dd-MM-yy}"; // Wenn Rückgabe kein String in {}, wird ToString()

            string nameOfDate = nameof(this.Date); // Bezeichner der Date-Property (Refactoring)

            // Nullable
            int? a = null;
            //int b = null;
            int b = a ?? -99; // a.HasValue ? a.Value : -99;

            // Inline-Null-Prüfung mit ?. (neu in C# 6)
            int? jahr = this.Date?.Year;

            Huhn huhn = null;
            // Neu in C# 8: Zuweisung nur, wenn huhn == null
            huhn ??= new Huhn() { Name = "Hilde", Gewicht = 1000 };


            // Nullable Reference Types (neu ab C# 8)
#nullable enable
            string text = null;
            Huhn huhn1 = null;
            int? wert = null;
#nullable disable

            // Auch für Collections, Arrays und Indizes (Vermeidung von IndexOutOfRange)
            //string customerName = Customers?[378]?.Name;

            // Klassische Initialisierung
            var Ortsliste = new Dictionary<int, string>()
            {
                {44797, "Bochum" },
                {20301, "Hamburg" },
                {4040, "Linz" }
            };
            // neu in C# 6
            var OrtslisteNeu = new Dictionary<int, string>()
            {
                [44797] = "Bochum",
                [20301] = "Hamburg",
                [4040] = "Linz"
            };

            // Exception Filter (neu in C# 6)
            string url;

            try
            {
                // Open(url);
            }
            catch (Exception ex) when (url == "")
            {

            }
            catch (Exception ex) when (ex is WebException webEx || ex is IndexOutOfRangeException ioEx)
            {

            }
            catch (Exception ex)
            {
                throw new NewFeatureException("Fehler beim Laden", ex);
            }

            // Neuerungen an switch
            Werte werte;

            switch (werte)
            {
                case Werte.A:
                case Werte.B:
                    break;
                case Werte.C:
                    break;
                default:
                    break;
            }

            // Neu in C# 8, nur Core
            string[] leute = { "Theo", "Klaus", "Werner", "Nicole", "Barbara", "Petra" };
            string klaus = leute[1];
            string barbara = leute[^2]; //zweiter von hinten

            Index iBarbara = ^2;
            string barbara2 = leute[iBarbara];

            Index iSample = Index.FromEnd(2);
            string barbara3 = leute[iSample];

            Range range = 0..2;
            string[] kerle = leute[range];
            string[] maedls = leute[3..5];
            string[] ab3 = leute[3..];
            string[] bis3 = leute[..3];

        }

        // seit C# 8:
        public string GetValue(string name, string erg) => erg switch
        {
            "Klaus" => $"{name} ist ein Mann.",
            "Petra" => $"{name} ist eine Frau.",
            _ => $"{name} ist irgendetwas."
        };

        public List<Huhn> GetHuehner(string filename)
        {
            using (XmlReader reader = XmlReader.Create(filename))   // Neu in C# 8: using ohne { }
            using (TextWriter writer = new TextWriter(filename))
            {

            }   // Writer wird disposed

        }   // Reader wird disposed

        public void Dispose()   // Neu in C# 8: Dispose erfordert kein IDisposable mehr!
        {

        }
    }

    enum Werte
    {
        A,
        B,
        C
    }
}
