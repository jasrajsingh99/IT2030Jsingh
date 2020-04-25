using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "This name is too long!")]
        [Display(Name = "First name")]
        public virtual string firstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "This name is too long!")]
        [Display(Name = "Last name")]
        public virtual string lastName { get; set; }

    }
}