using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models
{
    public class RegisterModel
    {
        [Key]
        [Required]
        [RegularExpression("^[0-9]{4}$")]
        [StringLength(4, MinimumLength = 4)]
        public string RegisterModelID { get; set; }
        public User user { get; set; }
        public CreditCard card { get; set; }
        public Address address { get; set; }
    }
}
