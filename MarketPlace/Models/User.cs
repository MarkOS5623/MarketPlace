using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
/* User Model
   Each user has an email and password
   A 4 number userid is used a primary key for each user
   A user can have multiple creditcards and addresses save on their account
   A user can also have multiple
   Booleans are used to check if the user is an Admin/Trader
   LoggedIn keeps track of whether to keep the user logged in at the end of a session
 */
namespace MarketPlace.Models
{
    public class User
    {
        public User()
        {

        }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [StringLength(50, MinimumLength = 4)]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Password must be between 4 and 20 charaters long")]
        public string Password { get; set; }
        [Key]
        [Required]
        [RegularExpression("^[0-9]{4}$")]
        [StringLength(4, MinimumLength = 4)]
        public string UserId { get; set; }
        [Required]
        public bool Admin { get; set; } = false;
        [Required]
        public bool Trader { get; set; } = false;
        [Required]
        public bool KeepLoggedIn { get; set; } = false;
        public List<CreditCard> CreditCards { get; set; }
        public List<Order> Orders { get; set; }
        public List<Address> Addresses { get; set; }
    }
}