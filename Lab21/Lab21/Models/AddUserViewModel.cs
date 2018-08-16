using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Lab21.Content;
using System.Web.UI.WebControls;
using System.Web.Mvc;

namespace Lab21.Models
{
    public class AddUserViewModel
    {


        [Display(Name = "First Name (Required)")]
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name (Required)")]
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Display(Name = "Email (Required)")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNum { get; set; }

        [Display(Name = "Zip Code")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Must exclusively consist of 5 digits.")]
        public string ZipCode { get; set; }

        [Display(Name = "Receive promo notifications?")]
        public bool Promo { get; set; }

        [Display(Name = "Favorite menu item")]
        [Required]
        public string FavCoffee { get; set; }
    }
}