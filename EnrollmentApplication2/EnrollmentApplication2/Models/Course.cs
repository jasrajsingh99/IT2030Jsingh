﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication2.Models
{
    public class Course
    {
        public virtual int CourseId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual int Credits { get; set; }


    }
}