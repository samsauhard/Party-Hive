using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyHive.Models.Account
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress, MaxLength(128)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(200, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long!")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords must match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Phone]
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name ="Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "User Type")]
        public string UserType { get; set; }
    }
}
