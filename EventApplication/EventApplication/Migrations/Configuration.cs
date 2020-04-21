namespace EventApplication.Migrations
{
    using EventApplication.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EventApplication.Models.EventDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EventApplication.Models.EventDbContext";
        }

        protected override void Seed(EventApplication.Models.EventDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var events = new List<Event>
            {
                new Event {Title="It's a wonderful life", Description = "It's a movie, bud",
                    StartDate =DateTime.Parse("2019-12-09"), StartTime=DateTime.Parse("7:00"),
                EndDate=DateTime.Parse("2019-12-10"), EndTime=DateTime.Parse("7:00"), Location = "Ohio",
                eventType="Movie", OrganizerName="Bruce Wayne", ContactInfo="notbatman@gmail.com",
                MaxTickets=int.Parse("30"), AvailableTickets=int.Parse("20")}
            };
            var eventtypes = new List<EventType>
            {
                new EventType {eventType="Music"},
                new EventType {eventType="Film"},
                new EventType {eventType="Fundraising"},
                new EventType {eventType="Gaming"},
                new EventType {eventType="Art"},
                new EventType {eventType="Comedy"},
                new EventType {eventType="Music"},
                new EventType {eventType="Shopping"},
                new EventType {eventType="Formal"},
                new EventType {eventType="Anime"},
            };
        }
    }
}
