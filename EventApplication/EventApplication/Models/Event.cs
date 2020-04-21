using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EventApplication.Models
{
    public class Event
    {
        [Key]
        [Required]
        [StringLength(50, ErrorMessage = "The title must be under 50 characters")]
        public string Title { get; set; }

        [StringLength(150, ErrorMessage = "The description must be under 150 characters")]
        public string Description { get; set; }

        [DisplayName("Start Date")]
        [Required(ErrorMessage = "Start date is invalid because it exists in the past")]
        public DateTime StartDate { get; set; }
       
        [Required]
        [DisplayName("Start Time")]
        public DateTime StartTime { get; set; }

        [Required]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [DisplayName("End Time")]
        public DateTime EndTime { get; set; }

        [Required]
        public string Location { get; set; }
        public string eventType { get; set; }

        [Required]
        [DisplayName("Organizers Name")]
        public string OrganizerName { get; set; }
        [DisplayName("Contact Info")]
        public string ContactInfo { get; set; }

        [Required]
        [DisplayName("Maximum Tickets")]
        [MinLength(1, ErrorMessage = "The maximum amount of tickets cannot be 0")]
        public int MaxTickets { get; set; }

        [Required]
        [DisplayName("Tickets Available")]
        [MinLength(1, ErrorMessage = "The amount of available tickets cannot be 0")]
        public int AvailableTickets { get; set; }
    }
}