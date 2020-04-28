using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
    {
        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "This name is too long!")]
        [Display(Name = "First name")]
        [InvalidChars("*", ErrorMessage = "Last name contains an invalid character.")]
        public virtual string firstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "This name is too long!")]
        [Display(Name = "Last name")]
        [InvalidChars("*", ErrorMessage = "Last name contains an invalid character.")]
        public virtual string lastName { get; set; }

        //[MinimumAge(20)]
        [MinimumAge(20)]
        public virtual int Age { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }

        [StringLength(5)]
        public string Zipcode { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Check if Address2 is the same as Address1. If so show an error “Address2 cannot be the same as Address1” on Address2 field. 
            //Check if State is 2 digits long. Otherwise show an error message “Enter a 2 digit State code”. 
            //Check if Zipcode is 5 digits long. Otherwise show an error message “Enter a 5 digit Zipcode” 
            if (Address1 == Address2 || Address2 == Address1)
            {
                yield return (new ValidationResult("Address2 cannot be the same as Address1"));
            }

            if (State.Length < 2 || State.Length > 2)
            {
                yield return (new ValidationResult("Please enter a 2 digit State"));
            }
           
            //Check if Zipcode is 5 digits long. Otherwise show an error message “Enter a 5 digit Zipcode” 
            if (Zipcode.Length > 5 || Zipcode.Length < 5)
                {
                yield return (new ValidationResult("Please enter a 5 digit zipcode"));
            }
           
            throw new NotImplementedException();
        }
    }
}