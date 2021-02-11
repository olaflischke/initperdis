using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace UserControlsMitViewModelsMvvm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase //IViewModel
    {
        public MainWindowViewModel()
        {
            this.DisplayControl1 = new RelayCommand(p => !IsViewModelOfType<Control1ViewModel>(), a => this.ViewModel = new Control1ViewModel());
            this.DisplayControl2 = new RelayCommand(p => !IsViewModelOfType<Control2ViewModel>(), a => this.ViewModel = new Control2ViewModel());
        }

        private bool IsViewModelOfType<T>()
        {
            if (this.ViewModel is T)
            {
                return true;
            }

            return false;
        }

        private IViewModel _viewModel;

        public IViewModel ViewModel
        {
            get => _viewModel; set
            {
                _viewModel = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand DisplayControl1 { get; set; }
        public RelayCommand DisplayControl2 { get; set; }

    }
}
