using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EnrollmentApplication.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [StringLength(50, ErrorMessage = "Please enter a valid name")]
        public virtual string firstName { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [StringLength(50, ErrorMessage = "Please enter a valid name")]
        public virtual string lastName { get; set; }

       [MinimumAge (20)]
       //[MinimumAge]
        public virtual int Age { get; set; }


        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }


    }
}