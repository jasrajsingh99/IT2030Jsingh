using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class Order
    {
       
           [Key]
            public int RecordId { get; set; }

            public string OrderId { get; set; }

            public int EventId { get; set; }

            //The virtual tag doesn't add it as a column in the database

            public virtual Event EventSelected { get; set; }

            public int Count { get; set; }

            public DateTime DateCreated { get; set; }
        }
}