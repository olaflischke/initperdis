using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EierfarmBl
{
    public class Ei
    {
        private Ei()
        {

        }

        /// <summary>
        /// Konstruktor für ein Ei
        /// </summary>
        /// <param name="mutter">Das Geflügel, das dieses Ei legen soll.</param>
        public Ei(IEiLeger mutter)
        {
            Random random = new Random();
            this.Gewicht = random.Next(45, 81);
            //this.Farbe = mutter.Farbindikator; 

            this.Mutter = mutter;
        }


        // Backing Field
        private double _gewicht;

        [XmlAttribute(AttributeName = "Weight")]
        // Öffentliche Eigenschaft
        public double Gewicht
        {
            get { return _gewicht; } // g = meinEi.Gewicht;
            set
            {
                if (value > 0)
                {
                    _gewicht = value;
                }
                else
                {
                    throw new Exception("Gewicht muss größer als Null sein!");
                }
            } // meinEi.Gewicht = 65;
        }

        // "Auto-Property"
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime Legedatum { get; set; } = DateTime.Now;

        [XmlElement(ElementName ="Color")]
        public EiFarbe Farbe { get; set; }

        [XmlIgnore]
        public IEiLeger Mutter { get; set; }
    }

    public enum EiFarbe
    {
        Hell,
        Dunkel,
        Gruen
    }
}
