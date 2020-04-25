using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Enrollment 
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "You need to complete this field")]
        [RegularExpression(@"[A-F]", ErrorMessage = "Grades can only be in A-F format")]
        public virtual string Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        //IsActive, AssignedCampus, EnrollmentSemester, EnrollmentYear
        public virtual bool IsActive { get; set; }

        [Required( ErrorMessage = "You need to complete this field")]
        [Display(Name = "Assigned Campus")]
        public virtual string AssignedCampus { get; set; }

        [Required(ErrorMessage = "You need to complete this field")]
        [Display(Name = "Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }

        [Range(typeof(int), "2018", "2022", ErrorMessage = "The date cannot be before 2018")]
        public virtual int EnrollmentYear { get; set; }
    }
}