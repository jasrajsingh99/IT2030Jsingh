using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;

namespace EnrollmentApplication.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<EnrollmentDB>
    {
        protected override void Seed(EnrollmentDB context)
        {
            var Student  = new List<Student>
            {
                 new Student { firstName = "Jeff1 " },
                 new Student { firstName = "Jeff2 " },
                 new Student { firstName = "Jeff3 " },
                 new Student { firstName = "Jeff4 " },
                 new Student { firstName = "Jeff5 " },
                 new Student { lastName = "Jeff1 " },
                 new Student { lastName = "Jeff2 " },
                 new Student { lastName = "Jeff3 " },
                 new Student { lastName = "Jeff4 " },
                 new Student { lastName = "Jeff5 " }

            };

    
        }
        }
}