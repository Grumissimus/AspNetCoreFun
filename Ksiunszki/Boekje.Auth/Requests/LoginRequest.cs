using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boekje.Auth.Requests
{
    public class LoginRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "The email address is required to log in")]
        [Display(Name = "E-Mail Address")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The password is required to log in")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
