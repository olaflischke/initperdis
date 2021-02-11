using ChinookDal.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ChinookExplorerUi
{
    public class ucExplorerViewModel
    {
        private Dictionary<Genre, IEnumerable<Artist>> _artistsByGenre;

        public Dictionary<Genre, IEnumerable<Artist>> ArtistsByGenre
        {
            get { return _artistsByGenre; }
            set { _artistsByGenre = value; }
        }

    }
}
