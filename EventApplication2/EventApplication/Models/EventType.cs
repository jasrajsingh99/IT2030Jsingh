using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class EventType
    {
        [Key]
        public virtual int EventTypeId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Type cannot exceed 50 characters")]
        public virtual string Type { get; set; }
    }
}