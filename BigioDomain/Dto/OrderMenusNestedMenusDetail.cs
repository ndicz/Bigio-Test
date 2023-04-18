using BigioDomain.Entities;

namespace BigioDomain.Dto
{
    public class OrderMenusNestedMenusDetail
    {
        public int orme_id { get; set; }

        public string? orme_order_number { get; set; }

        public decimal orme_total_amount { get; set; }
        public decimal orme_total_discount { get; set; }

        public virtual ICollection<OrmeDetail>? MenuDetail { get; set; }
    }
}
