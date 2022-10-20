using System.ComponentModel.DataAnnotations;

namespace draquapuri.Model
{
    public class Login
    {
        [Key]
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
