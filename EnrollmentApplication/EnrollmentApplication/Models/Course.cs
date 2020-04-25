using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }


        [Required]
        [StringLength(160, MinimumLength = 3)]
        public virtual string Title { get; set; }


        [Display(Name = "Description")]
        public virtual string Description { get; set; }

        [Required]
        [Display(Name = "Number of credits")]
        [Range(typeof(int), "1", "4")]
        public virtual int Credits { get; set; }
    }
}