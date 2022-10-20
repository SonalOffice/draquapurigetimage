using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace draquapuri.Model
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public List<ProductImage> Images { get; set; }

        [Required]
        public string? ShortDescription { get; set; }

        [Required]
        public string? LongDescription { get; set; }

        [Required]
        public int NormalPrice { get; set; }

        [Required]
        public int OfferPrice { get; set; }

        [Required]
        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;

        //public virtual ProductImage ProductImage { get; set; }



        // Foreign key   
        //[Display(Name = "ProductImage")]
        //public virtual int Id { get; set; }

        //[ForeignKey("Id")]
        //public virtual ProductImage ProductImages { get; set; }
    }
}
