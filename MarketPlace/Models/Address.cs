using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
/* Address Model
   Street and Zipcode are required for address
   Apartment and floor numbers are optional depending if they are valid(ie not a private home)
 */
namespace MarketPlace.Models
{
    public class Address
    {
        [RegularExpression("^[0-9]{4}$")]
        public string User_ID { get; set; }
        [ForeignKey("User_ID")]
        public virtual User User { get; set; }
        [Key]
        [Required]
        [RegularExpression("^[0-9]{4}$")]
        [StringLength(4, MinimumLength = 4)]
        public string AddressID { get; set; }
        [Required]
        public string Street { set; get; }
        [Required]
        public string Zipcode { set; get; }
        public int ApartmentNum { set; get; }
        public int FloorNum { set; get; }
    }
}