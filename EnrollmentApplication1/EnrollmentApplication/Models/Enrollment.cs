using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [RegularExpression("abcdef", ErrorMessage = "Enter Grade between A and F")]
        public virtual string Grade { get; set; }
        public virtual string StudentObject { get; set; }
        public virtual string CourseObject { get; set; }
        public virtual Boolean IsActive { get; set; }

        [Required( ErrorMessage = "Required Field")]
        [Display(Name = "Assigned Campus")]
        public virtual string AssignedCampus { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Display(Name = "Enrolled In Semester")]
        public virtual string EnrollmentSemester { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [StringLength(3000,MinimumLength = 2018, ErrorMessage = "Cannot be less than 2018")]
        public virtual string EnrollmentYear { get; set; }

        public virtual string Notes { get; set; } 
    }
}