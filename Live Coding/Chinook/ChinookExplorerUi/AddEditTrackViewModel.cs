using ChinookDal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChinookExplorerUi
{
    public class AddEditTrackViewModel : INotifyPropertyChanged
    {
        private bool? result;

        public AddEditTrackViewModel(Track track)
        {
            this.Track = track;
            this.SaveCommand = new RelayCommand(p => CanSave(), a => SaveAction());
        }

        private void SaveAction()
        {
            this.Result = true;
        }

        private bool CanSave()
        {
            return true;
        }

        public Track Track { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public bool? Result
        {
            get => result; 
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand SaveCommand { get; set; }

    }
}
