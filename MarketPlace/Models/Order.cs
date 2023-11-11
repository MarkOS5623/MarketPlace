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
        public virtual User User { get; set; }
        [Required]
        public string User_ID { get; set; }
        [ForeignKey("User_ID")]
        [Required]
        public List<Item> Items { get; set; }
        [Required]
        public Address address { get; set; }
        [Required]
        public double Totalprice { get; set; } 
        [Required]
        public int orderID { get; set; }
    }
}