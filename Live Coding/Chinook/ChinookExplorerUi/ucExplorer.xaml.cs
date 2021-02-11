using ChinookDal.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChinookExplorerUi
{
    /// <summary>
    /// Interaktionslogik für ucExplorer.xaml
    /// </summary>
    public partial class ucExplorer : UserControl
    {
        public ucExplorer(ucExplorerViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }

        public Dictionary<Genre, IEnumerable<Artist>> ArtistsByGenre
        {
            get { return (Dictionary<Genre, IEnumerable<Artist>>)GetValue(ArtistsByGenreProperty); }
            set { SetValue(ArtistsByGenreProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArtistsByGenre.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArtistsByGenreProperty =
            DependencyProperty.Register("ArtistsByGenre", typeof(Dictionary<Genre, IEnumerable<Artist>>), typeof(ucExplorer), new PropertyMetadata(null));


    }
}
