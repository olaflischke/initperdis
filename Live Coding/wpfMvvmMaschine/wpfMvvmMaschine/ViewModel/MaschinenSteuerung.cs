using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfMvvmMaschine.Model;

namespace wpfMvvmMaschine.ViewModel
{
    public class MaschinenSteuerung
    {
        public MaschinenSteuerung()
        {
            this.StartenCommand = new RelayCommand(p => CanStarten(), a => Starten());
            this.StoppenCommand = new RelayCommand(p => CanStoppen(), a => Stoppen());
            this.SchnellerCommand = new RelayCommand(p => CanSchneller(), a => Schneller());
            this.LangsamerCommand = new RelayCommand(p => CanLangsamer(), a => Langsamer());
        }

        private bool CanLangsamer()
        {
            if (this.Maschine.Geschwindigkeit>1)
            {
                return true;
            }

            return false;
        }

        private void Langsamer()
        {
            this.Maschine.Geschwindigkeit--;
        }

        private bool CanSchneller()
        {
            return true;
        }

        private void Schneller()
        {
            this.Maschine.Geschwindigkeit++;
        }

        private bool CanStoppen()
        {
            return this.Maschine.IstAmLaufen;
        }

        private void Stoppen()
        {
            this.Maschine.Stopp();
        }

        private bool CanStarten()
        {
            return !this.Maschine.IstAmLaufen;
        }

        private void Starten()
        {
            this.Maschine.Start();
        }

        public TennisballWurfmaschine Maschine { get; set; } = new TennisballWurfmaschine();
        public RelayCommand StartenCommand { get; set; }
        public RelayCommand StoppenCommand { get; set; }
        public RelayCommand SchnellerCommand { get; set; }
        public RelayCommand LangsamerCommand { get; set; }
    }
}
