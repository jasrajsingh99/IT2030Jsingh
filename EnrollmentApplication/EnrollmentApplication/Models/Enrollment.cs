using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual double Grade { get; set; }
        public virtual string StudentObject { get; set; }
        public virtual string CourseObject { get; set; }
    }
}