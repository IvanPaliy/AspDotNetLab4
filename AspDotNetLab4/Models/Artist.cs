using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspDotNetLab4.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        [Required]
        public string ArtistName { get; set; }

        public ICollection<Album> Albums { set; get; }
    }
}
