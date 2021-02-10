using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ChinookDal.Model
{
    [Table("Track")]
    [Index(nameof(AlbumId), Name = "IFK_TrackAlbumId")]
    [Index(nameof(GenreId), Name = "IFK_TrackGenreId")]
    [Index(nameof(MediaTypeId), Name = "IFK_TrackMediaTypeId")]
    public partial class Track// : IDataErrorInfo
    {
        private int milliseconds;

        //public string this[string propertyName]
        //{
        //    get
        //    {
        //        string _message = "";

        //        //if (propertyName == nameof(Name))
        //        //{
        //        //    if (string.IsNullOrWhiteSpace(this.Name) || this.Name.Length < 1 || this.Name.Length > 200)
        //        //    {
        //        //        _message = "Länge des Tracknamens ausserhalb des gültigen Bereichs (zwischen 1 und 200 Zeichen)";
        //        //    }
        //        //}
        //        //else 
        //        if (propertyName == nameof(Milliseconds))
        //        {
        //            if (this.Milliseconds < 1 || this.Milliseconds > Int32.MaxValue)
        //            {
        //                _message = $"Milliseconds ausserhalb des gültigen Bereichs (größer als 0 und kleiner als {Int32.MaxValue:#,##0}";
        //            }
        //        }
        //        else if (propertyName == nameof(UnitPrice))
        //        {
        //            if (this.UnitPrice < 0)
        //            {
        //                _message = "Verschenken (Preis = 0) ist ok, Bestechung nicht.";
        //            }
        //        }

        //        return _message;
        //    }
        //}

        //public string Error => throw new Exception();

        [Key]
        public int TrackId { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public int? AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int? GenreId { get; set; }
        [StringLength(220)]
        public string Composer { get; set; }
        public int Milliseconds
        {
            get => milliseconds; set
            {
                milliseconds = value;
            }
        }
        public int? Bytes { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal UnitPrice { get; set; }

        [ForeignKey(nameof(AlbumId))]
        [InverseProperty("Tracks")]
        public virtual Album Album { get; set; }
        [ForeignKey(nameof(GenreId))]
        [InverseProperty("Tracks")]
        public virtual Genre Genre { get; set; }

    }
}
