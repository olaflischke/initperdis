using System;
using System.Collections.Generic;
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
    public partial class Track
    {
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
        public int Milliseconds { get; set; }
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
