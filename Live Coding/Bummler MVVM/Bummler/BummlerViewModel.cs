using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BummlerApp
{
    public class BummlerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Bummler bummler;

        public BummlerViewModel()
        {
            bummler = new Bummler(this);
        }

        public ICommand BummelnCommand
        {
            get
            {
                return new RelayCommand(p => true, a => BummelAction());
            }
        }

        private string _bummelMeldung;


        public string BummelMeldung
        {
            get => _bummelMeldung;
            set
            {
                _bummelMeldung = value;
            }
        }

        private async void BummelAction()
        {
            try
            {
                this.BummelMeldung = await bummler.BummelnAsync();

            }
            catch (Exception ex)
            {
                BummelMeldung = $"Fehler in BummelAction: {ex.Message}";
            }
        }
    }
}
