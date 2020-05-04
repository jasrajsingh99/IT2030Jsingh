using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class Event : IValidatableObject
    {
        [Key]
        public virtual int EventId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The title cannot exceed 50 characters.")]
        public virtual string Title { get; set; }

        [StringLength(150, MinimumLength = 3, ErrorMessage = "The description cannot exceed 150 characters.")]
        public virtual string Description { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public virtual DateTime StartDate { get; set; }

        public virtual string StartTime { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public virtual DateTime EndDate { get; set; }

        public virtual string EndTime { get; set; }

        public virtual string Location { get; set; }

        public virtual EventType EventType { get; set; }

        public virtual string OrganizerName { get; set; }

        public virtual string Number { get; set; }

        public virtual int MaxTickets { get; set; }
                       
        public virtual int TicketsAvailable { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var today = DateTime.Now;
            var yesterday = today.AddDays(-1);

            if (StartDate < yesterday)
            {
                yield return (new ValidationResult("Remember: you cannot have an event in the past!"));
            }

            if (EndDate < yesterday)
            {
                yield return (new ValidationResult("Remember: you cannot have an event in the past!"));
            }

            if (EndDate < StartDate)
            {
                yield return (new ValidationResult("The end of the event cannot exist before the start"));
            }

            if (MaxTickets < 1)
            {
                yield return (new ValidationResult("You can't have an event with no tickets!"));
            }

            if (TicketsAvailable < 1)
            {
                yield return (new ValidationResult("Your event must have at least 1 ticket available!"));
            }

            
        }
    }
}