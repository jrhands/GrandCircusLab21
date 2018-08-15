using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

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
        public string ZipCode { get; set; }
    }
}