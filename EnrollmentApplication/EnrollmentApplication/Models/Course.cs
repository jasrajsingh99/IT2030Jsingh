using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Display(Name = "Course Title")]
        [StringLength(150, ErrorMessage = "Please enter a short title")]
        public virtual string Title { get; set; }

        [Display(Name = "Description")]
        public virtual string Description { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Range(typeof(int), "1", "4", ErrorMessage = "Please enter credits in a range of 1 to 4")]
        [Display(Name = "Number of Credits")]
        public virtual int Credits { get; set; }

    }
}