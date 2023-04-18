using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigioDomain.Entities
{
    [Table("resto_menus")]
    public class OrmeDetail
    {
        [Key]
           public int OmdeId { get; set; }
           public decimal OrmePrice { get; set; }
           public Int16 OrmeQty { get; set; }
        public decimal OrmeSubtotal { get; set; }
           public decimal OrmeDiscount { get; set; }
           public int OmdeOrmeId { get; set; }
           public int OmdeRemeId { get; set; }
            
        public string? RemeName { get; set; }

    }
}
