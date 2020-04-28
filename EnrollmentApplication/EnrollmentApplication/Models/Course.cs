using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Course : IValidatableObject
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

        public virtual string InstructorName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
        //Validation 1: Credits must be between 1 and 4
        if (Credits < 1 || Credits >4)
            {
                yield return (new ValidationResult("Credits must be between 1 and 4"));
            }

            //Validation 2: if description is over 100

            if (Description.Split(' ').Length > 100)
                {
                yield return (new ValidationResult("Your description is too verbose"));
            }

            throw new NotImplementedException();
        }
    }
}