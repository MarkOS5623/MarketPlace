using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarketPlace.Models
{
    public class Item
    {
        [Key]
        [Required]
        [RegularExpression("^[0-9]{4}$")]
        [StringLength(4, MinimumLength = 4)]
        public string ItemID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Size { get; set; }
        public string Colour { get; set; }
    }
}