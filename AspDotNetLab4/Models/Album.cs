using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspDotNetLab4.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        [Required]
        public string AlbumName { get; set; }

        [ForeignKey("Artist")]
        public int ArtistId { set; get; }
        public Artist Artist { set; get; }
    }
}
