using ChinookDal.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChinookDal
{
    public class ChinookRepository
    {
        ChinookContext dbContext = new ChinookContext();
        public Dictionary<Genre, IEnumerable<Artist>> GetArtistsByGenre()
        {

            var tracks = dbContext.Tracks.Include(x => x.Album.Artist.Albums).Include(x => x.Genre);
            var GenreArtistDict = tracks.ToList().GroupBy(x => x.Genre, x => x.Album.Artist).ToDictionary(x => x.Key, x => x.Distinct().OrderBy(y => y.Name).AsEnumerable());

            return GenreArtistDict;
        }

        public void SaveTrack(Track track)
        {

        }

        //public IEnumerable<Album> GetAlbumsByArtist(Artist artist)
        //{

        //}
    }
}
