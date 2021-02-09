using ChinookDal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChinookExplorerUi
{
    /// <summary>
    /// Interaktionslogik für AddEditTrack.xaml
    /// </summary>
    public partial class AddEditTrack : DialogBase
    {
        public AddEditTrack(Track track)
        {
            InitializeComponent();

            AddEditTrackViewModel viewModel = new AddEditTrackViewModel(track);
            this.DataContext = viewModel;

            viewModel.PropertyChanged += ViewModel_PropertyChanged;

            //this.DataContext = track;
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName=="Result")
            {
                this.DialogResult = true;
            }
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    this.DialogResult = true;
        //}
    }
}
