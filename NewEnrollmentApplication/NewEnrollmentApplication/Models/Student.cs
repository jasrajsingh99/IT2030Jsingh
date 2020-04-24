using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewEnrollmentApplication.Models
{
    public class Student
    {
        public virtual int StudentId { get; set; }
        public virtual string firstName { get; set; }
        public virtual string lastName { get; set; }
    }
}