using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INF272_Practical_2.Models
{
	public class PersonModel
	{
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Current Age")]
        public int Age { get; set; } = 0;

        [Display(Name = "Living Status")]
        public bool IsAlive { get; set; } = true;

        [Display(Name = "Personal Page Link")]
        public string myLink { get; set; }
    }
}