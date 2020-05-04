using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<EventDB>
    {
        protected override void Seed(EventDB context)
        {
            var eventtypes = new List<EventType>
            {
                new EventType { Type = "Concert"},
                new EventType { Type = "Volunteer"},
                new EventType { Type = "Workshop"},
                new EventType { Type = "Auction"},
                new EventType { Type = "Sale"},
                
                new EventType { Type = "Networking"},
                new EventType { Type = "Convention"},
                new EventType { Type = "Film"},
                new EventType { Type = "Food"},
                new EventType { Type = "Religious"},

            };

            new List<Event>
            {
                new Event { Title = "", Description = "", StartDate = ("05-01-2019") }

            };
        }

    }
}