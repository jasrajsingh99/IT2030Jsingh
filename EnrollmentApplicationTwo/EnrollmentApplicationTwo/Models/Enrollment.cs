using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplicationTwo.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual string Grade { get; set; }
        public virtual Student StudentObject { get; set; }
        public virtual string CourseObject { get; set; }
    }
}