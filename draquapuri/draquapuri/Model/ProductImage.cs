namespace draquapuri.Model
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Image { get; set; }
       
        public System.DateTime CreatedDate { get; set; } = DateTime.Now;
        public System.DateTime UpdatedDate { get; set; } = DateTime.Now;

        public virtual Product Product { get; set; }
    }
}
