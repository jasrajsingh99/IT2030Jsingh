using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class EventType
    {
        [Key]
        [Required]
        [DisplayName("Type")]
        [StringLength(50, ErrorMessage = "The event type must be under 50 characters")]
        public string eventType { get; set; }
    }
}