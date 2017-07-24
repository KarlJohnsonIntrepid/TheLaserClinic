using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheLaserClinc.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Your name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Your email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Your contact number is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "The subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "The message is required")]
        public string Message { get; set; }

        public bool Submitted { get; set; }
        public bool Failed { get; set; }
    }
}