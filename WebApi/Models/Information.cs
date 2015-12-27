using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi.Models
{
    public class Information
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        internal ActionResult View(object webControls)
        {
            throw new NotImplementedException();
        }
    }
}