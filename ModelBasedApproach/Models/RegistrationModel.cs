using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelBasedApproach.Models
{
    public class RegistrationModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="UserName Cannot be Empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password Cannot be Empty")]
        public string Password { get; set; }
      

        [Compare("Password",ErrorMessage ="Pwd and Cpwd its not matching")]
        public string ConfirmPassword { get; set; }
        [Range(18,40,ErrorMessage ="Age Should be between 18-40")]
        public int Age { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        [StringLength(100)]
        public string Address { get; set; }

    }
}