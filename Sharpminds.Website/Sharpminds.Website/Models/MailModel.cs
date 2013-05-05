using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sharpminds.Website.Models
{
    public class MailModel
    {
        [Required]
        //[StringLength(1)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Required]
        //[MinLength(8, ErrorMessage = "Must enter valid phone number e.g 1234 56789.")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        
        [Required]
        //[MinLength(6, ErrorMessage = "Must enter valid email.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required]
        [MinLength(1, ErrorMessage = "Must enter subject.")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        
        [Required]
        //[MinLength(10, ErrorMessage = "Minimum message length of 10 characters.")]
        [Display(Name = "Message")]
        public string Message { get; set; }

        public bool MailSent { get; set; }
    }
}