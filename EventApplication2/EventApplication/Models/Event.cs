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
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please keep your title to 50 characters or less")]
        public virtual string Title { get; set; }

        [StringLength(150, MinimumLength = 3, ErrorMessage = "Please keep your description to 150 characters or less")]
        public virtual string Description { get; set; }

        [Required]
        public virtual DateTime StartDate { get; set; }

        [Required]
        public virtual DateTime StartTime { get; set; }

        [Required]
        public virtual DateTime EndDate { get; set; }

        [Required]
        public virtual DateTime EndTime { get; set; }

        [Required]
        public virtual string Location { get; set; }

        public virtual EventType EventType { get; set; }

        [Required]
        public virtual string OrganizerName { get; set; }

        public virtual string Email { get; set; }

        [Required]
        public virtual int MaxTickets { get; set; }

        [Required]
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

            
            throw new NotImplementedException();
        }
    }
}