using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace draquapuri.Model
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public byte[] Image { get; set; }

        [Required]
        public System.DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        public System.DateTime UpdatedDate { get; set; } = DateTime.Now;


        // Foreign key 
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Products Products { get; set; }
    }

}


