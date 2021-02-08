using System;
using System.Collections.ObjectModel;

namespace EierfarmBl
{
    public interface IGefluegel
    {
        ObservableCollection<Ei> Eier { get; set; }
        double Gewicht { get; set; }
        Guid Id { get; }
        string Name { get; set; }

        event EventHandler<GefluegelEventArgs> EigenschaftGeaendert;

        void EiLegen();
        void Fressen();
    }
}