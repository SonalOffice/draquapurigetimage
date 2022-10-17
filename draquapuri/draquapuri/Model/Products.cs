using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace draquapuri.Model
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
   
        public string? Name { get; set; }

        public string? ShortDescription { get; set; }

        public string? LongDescription { get; set; }

        public int NormalPrice { get; set; }

        public int OfferPrice { get; set; }

        public DateTime? CreatedDate { get; set; }
      
    }
}
