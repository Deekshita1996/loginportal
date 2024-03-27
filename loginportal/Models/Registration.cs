using System.ComponentModel.DataAnnotations;

namespace loginportal.Models
{
    public class Registration
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string repeatpassword { get; set; }
        [Required]
        public string phoneNumber { get; set; }
        [Required]
        public string  address { get; set; }
    }
}
