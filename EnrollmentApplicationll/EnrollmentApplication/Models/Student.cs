using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        //Student Id, first name, and last name

        public virtual int StudentId { get; set; }
        public virtual string firstName { get; set; }
        public virtual string lastName { get; set; }

    }
}