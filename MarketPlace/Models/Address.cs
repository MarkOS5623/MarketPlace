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
        public virtual User User { get; set; }
        public string User_ID { get; set; }
        [ForeignKey("User_ID")]
        [Required]
        public string Street { set; get; }
        [Required]
        public string Zipcode { set; get; }
        public int ApartmentNum { set; get; }
        public int FloorNum { set; get; }
    }
}