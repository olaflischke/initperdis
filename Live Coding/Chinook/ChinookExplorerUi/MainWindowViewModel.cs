using ChinookDal;
using ChinookDal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChinookExplorerUi
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        ChinookRepository repo = new ChinookRepository();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }



        public MainWindowViewModel()
        {
            this.ArtistsByGenre = repo.GetArtistsByGenre();

            this.EditTrackCommand = new RelayCommand(p => CanEditTrack(), a => EditTrackAction());
            this.NewTrackCommand = new RelayCommand(p => CanNewTrack(), a => NewTrackAction());
        }

        private bool CanNewTrack()
        {
            return true;
        }

        private void NewTrackAction()
        {
            Track track = new Track();
            AddEditTrack dlgNewTrack = new AddEditTrack(track);
            if (dlgNewTrack.ShowDialog() == true)
            {
                repo.SaveTrack(track);
            }
        }

        private bool CanEditTrack()
        {
            if (this.SelectedTrack != null)
            {
                return true;
            }
            return false;
        }

        private void EditTrackAction()
        {
            AddEditTrack dlgEditTask = new AddEditTrack(this.SelectedTrack);
            if (dlgEditTask.ShowDialog() == true)
            {
                repo.SaveTrack(this.SelectedTrack);
            }

        }

        private Dictionary<Genre, IEnumerable<Artist>> _artistsByGenre;

        public Dictionary<Genre, IEnumerable<Artist>> ArtistsByGenre
        {
            get { return _artistsByGenre; }
            set { _artistsByGenre = value; }
        }

        public RelayCommand EditTrackCommand { get; set; }
        public RelayCommand NewTrackCommand { get; set; }

        public Track SelectedTrack { get; set; }
        public Artist SelectedArtist { get; set; }
    }
}
