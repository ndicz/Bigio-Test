using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigioDomain.Entities
{
    [Table("resto_menus")]
    public class MenuPhotos
    {
        [Key]
        public int RempId  { get; set; } 
        public string RempThumbnailFilename { get; set; }
        public string RempPhotoFilename { get; set; }
        public bool RempPrimary { get; set; }
        public String RempUrl { get; set; }
        public int RempRemeId { get; set; }
    }
}
