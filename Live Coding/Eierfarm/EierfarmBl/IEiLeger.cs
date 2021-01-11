using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public interface IEiLeger
    {
        event EventHandler<GefluegelEventArgs> EigenschaftGeaendert;

        ObservableCollection<EierfarmBl.Ei> Eier { get; set; }
        double Gewicht { get; set; }

        void EiLegen();
    }
}