using System.ComponentModel.DataAnnotations;

namespace loginportal.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "email")]
        public string email { get; set; }
        [Required]
        [Display(Name ="Password Hash")]
        public string password { get; set; }
    }
}
