using EierfarmBl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmUiWpf
{
    public class ViewModel : INotifyPropertyChanged
    {
        private IEiLeger _selectedTier;

        public ViewModel()
        {
            this.EiLegenCommand = new RelayCommand(p => CanEiLegen(), a => EiLegenAction());
            this.FuetternCommand = new RelayCommand(p => CanFuettern(), a => FuetternAction());
            this.NeuesHuhnCommand = new RelayCommand(p => CanNeuesHuhn(), a => NeuesHuhnAction());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        private void NeuesHuhnAction()
        {
            Huhn huhn = new Huhn("Neues Huhn");
            this.Tiere.Add(huhn);
            this.SelectedTier = huhn;
        }

        private bool CanNeuesHuhn()
        {
            return true;
        }

        private void FuetternAction()
        {
            if (this.SelectedTier is IFresser tier)
            {
                tier.Fressen();
            }
        }

        private bool CanFuettern()
        {
            if (this.SelectedTier != null)
            {
                return true;
            }
            return false;
        }

        private void EiLegenAction()
        {
            if (this.SelectedTier is IEiLeger tier)
            {
                tier.EiLegen();
            }
        }

        private bool CanEiLegen()
        {
            if (this.SelectedTier != null)
            {
                return true;
            }
            return false;
        }

        public IEiLeger SelectedTier
        {
            get => _selectedTier; set
            {
                if (this.Tiere.Contains(value))
                {
                    _selectedTier = value;
                    OnPropertyChanged();
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public ObservableCollection<IEiLeger> Tiere { get; set; } = new ObservableCollection<IEiLeger>();

        public RelayCommand NeueGansCommand { get; set; }
        public RelayCommand NeuesHuhnCommand { get; set; }
        public RelayCommand NeuesSchnabeltierCommand { get; set; }

        public RelayCommand FuetternCommand { get; set; }
        public RelayCommand EiLegenCommand { get; set; }
    }
}
