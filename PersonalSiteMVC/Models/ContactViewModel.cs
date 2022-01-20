using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Added for access to Data Annotations used for validation

namespace PersonalSiteMVC.Models
{
    public class ContactViewModel
    {

        //Properties
        [Required(ErrorMessage = "*Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Subject { get; set; }

        [Required(ErrorMessage = "*Message is required")]
        [UIHint("MultilineText")] //Converts any <input>s for this property into a <textarea>
        public string Message { get; set; }

    }
}