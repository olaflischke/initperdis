using System;

namespace EierfarmBl
{
    public class GefluegelEventArgs : EventArgs
    {
        public GefluegelEventArgs(string property)
        {
            this.GeaenderteProperty = property;
        }

        public string GeaenderteProperty { get; set; }

    }
}