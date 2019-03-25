using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SandwichShop.Models
{

    public class OrderViewModel
    {
    
        [Required(ErrorMessage = "We need your name")]
        [Display(Name = "Your Name")]   
        public string ContactName { get; set; }

        [Display(Name = "Your Email")]
        [EmailAddress]
        public string ContactEmail { get; set; }

        [Phone]
        public string ContactPhoneNumber { get; set; }

        [Required]
        public string ShippingStreet1 { get; set; }

        public string ShippingStreet2 { get; set; }

        [Required]
        public string ShippingCity { get; set; }

        [Required]
        public string ShippingRegion { get; set; }

        [Required]
        public string ShippingCountry { get; set; }

        [Required]
        public string ShippingPostalCode { get; set; }

    }
}