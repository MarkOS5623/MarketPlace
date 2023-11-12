using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MarketPlace.Models
{
    public class Order
    {
        [ForeignKey("User_ID")]
        public string User_ID { get; set; }
        public virtual User User { get; set; }
        [Key]
        [Required]
        [RegularExpression("^[0-9]{4}$")]
        [StringLength(4, MinimumLength = 4)]
        public string OrderID { get; set; }
        [Required]
        public List<Item> Items { get; set; }
        [Required]
        public Address address { get; set; }
        [Required]
        public double Totalprice { get; set; } 
    }
}