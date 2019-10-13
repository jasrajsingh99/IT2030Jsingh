﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        public InvalidCharsAttribute() : base("{0} Notes contains unacceptable characters!” ")
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value != null)
            {
                
                    var errormessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errormessage);
                
            }

            return ValidationResult.Success;
            //return base.IsValid(value, validationContext);
        }
    }

}