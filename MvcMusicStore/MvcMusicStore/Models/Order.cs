﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserName { get; set; }

        [Required]
        [StringLength(160, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(160, MinimumLength = 3)]
        public string LastName { get; set; }


        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        [Required]
        [RegularExpression(@"A-Za-Z0-9._%+=]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required]
        [Range(typeof(decimal),"0.00", "49.99")]
        public decimal Total { get; set; }
    }
}