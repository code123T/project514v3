namespace EcommerceWebUILab.Models.Entity
{
    public class Basket:BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
    }
}
