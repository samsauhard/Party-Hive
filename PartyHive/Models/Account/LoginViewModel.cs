using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyHive.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress, MaxLength(500)]
        [Display(Name ="Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "User Type")]
        public string UserType { get; set; }
    }
}
