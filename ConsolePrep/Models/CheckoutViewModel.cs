using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace ContentPal.App.Models
{
    public class CheckoutViewModel
    {
        
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your first name")]
        public string fName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name")]
        public string lName { get; set; }
        
        
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your billing email")]
        public string email { get; set; }
        
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter your billing address")]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        public string Address2 { get; set; }
        
        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter your billing address")]
        public string City { get; set; }
        
        [Display(Name = "State")]
        [Required(ErrorMessage = "Please select your billing state")]
        public string State { get; set; }
        
        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Please enter your billing zip code")]
        public string Zip { get; set; }
    }
}
