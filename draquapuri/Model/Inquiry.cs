using System.ComponentModel.DataAnnotations;

namespace draquapuri.Model
{
    public class Inquiry
    {
        [Key]
        public int InquiryId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Message { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }


}
