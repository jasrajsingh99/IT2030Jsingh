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
                new EventType { EventName = "Concert"},
                new EventType { EventName = "Volunteer"},
                new EventType { EventName = "Workshop"},
                new EventType { EventName = "Auction"},
                new EventType { EventName = "Sale"},
                                    
                new EventType { EventName = "Networking"},
                new EventType { EventName = "Convention"},
                new EventType { EventName = "Film"},
                new EventType { EventName = "Food"},
                new EventType { EventName = "Religious"},
            };

            new List<Event>
            {
                //Concerts
                    new Event { Title = "Wheel Big Phish", Description = "Ska classic Wheel Big Phish is at the Pog Shop",
                        StartDate =DateTime.ParseExact("05-04-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("05-05-2020","MM-dd-yyyy",null), EndTime = "9:00PM",
                        Location = "Cleveland", EventType = eventtypes.Single(e => e.EventName == "Concert"), OrganizerName = "Pog Shop",
                        Number = "330-888-8864", MaxTickets = 60, TicketsAvailable = 60},

                    new Event { Title = "Neutralize Silk Hostel", Description = "Indie band is back after years away from touring",
                        StartDate =DateTime.ParseExact("05-29-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("05-29-2020","MM-dd-yyyy",null), EndTime = "11:00PM",
                        Location = "Cleveland", EventType = eventtypes.Single(e => e.EventName == "Concert"), OrganizerName = "Pog Shop",
                        Number = "330-888-8864", MaxTickets = 60, TicketsAvailable = 60},

                    new Event { Title = "Chinese Football", Description = "Wuhan based band has come to Cleveland for a show",
                        StartDate =DateTime.ParseExact("05-20-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("05-20-2020","MM-dd-yyyy",null), EndTime = "9:00PM",
                        Location = "Cleveland", EventType = eventtypes.Single(e => e.EventName == "Concert"), OrganizerName = "Pog Shop",
                        Number = "330-888-8864", MaxTickets = 50, TicketsAvailable = 50},

                //Volunteer

                    new Event { Title = "Soup kitchen", Description = "Help feed the homeless",
                        StartDate =DateTime.ParseExact("05-05-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("05-09-2020","MM-dd-yyyy",null), EndTime = "11:00PM",
                        Location = "Hudson", EventType = eventtypes.Single(e => e.EventName == "Volunteer"), OrganizerName = "Souper Man",
                        Number = "330-888-8865", MaxTickets = 10, TicketsAvailable = 10},

                    new Event { Title = "Social distancing", Description = "Stay away from everyone",
                        StartDate =DateTime.ParseExact("05-04-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("05-09-2020","MM-dd-yyyy",null), EndTime = "11:00PM",
                        Location = "Hudson", EventType = eventtypes.Single(e => e.EventName == "Volunteer"), OrganizerName = "Souper Man",
                        Number = "330-888-8865", MaxTickets = 90, TicketsAvailable = 90},

                    new Event { Title = "Building homes", Description = "Build homes for the homeless",
                        StartDate =DateTime.ParseExact("05-10-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("05-11-2020","MM-dd-yyyy",null), EndTime = "11:00PM",
                        Location = "Hudson", EventType = eventtypes.Single(e => e.EventName == "Volunteer"), OrganizerName = "Souper Man",
                        Number = "330-888-8865", MaxTickets = 10, TicketsAvailable = 10},

                 //Workshop

                    new Event { Title = "How to make friends in your 30s", Description = "Learn how to make friends as you age",
                        StartDate =DateTime.ParseExact("05-04-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("05-06-2020","MM-dd-yyyy",null), EndTime = "8:00PM",
                        Location = "Highland", EventType = eventtypes.Single(e => e.EventName == "Workshop"), OrganizerName = "Tri-C",
                        Number = "330-888-8866", MaxTickets = 20, TicketsAvailable = 20},


                    new Event { Title = "Find your voice", Description = "Learn how to become a voice actor",
                        StartDate =DateTime.ParseExact("03-24-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("03-25-2020","MM-dd-yyyy",null), EndTime = "9:00PM",
                        Location = "Highland", EventType = eventtypes.Single(e => e.EventName == "Workshop"), OrganizerName = "Tri-C",
                        Number = "330-888-8866", MaxTickets = 10, TicketsAvailable = 10},


                    new Event { Title = "Raise chickens", Description = "Learn how to raise backyard chickens",
                        StartDate =DateTime.ParseExact("05-10-2021","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("05-11-2021","MM-dd-yyyy",null), EndTime = "10:00PM",
                        Location = "Highland", EventType = eventtypes.Single(e => e.EventName == "Workshop"), OrganizerName = "Tri-C",
                        Number = "330-888-8866", MaxTickets = 15, TicketsAvailable = 15},

                 //Auction

                    
                    new Event { Title = "Auction Hunters", Description = "Become an auctioneer",
                        StartDate =DateTime.ParseExact("06-10-2019","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("06-11-2019","MM-dd-yyyy",null), EndTime = "7:00PM",
                        Location = "Solon", EventType = eventtypes.Single(e => e.EventName == "Auction"), OrganizerName = "Saleby's",
                        Number = "330-888-8867", MaxTickets = 15, TicketsAvailable = 15},

                    new Event { Title = "Vintage Soda Auction", Description = "Win vintage sode from the 1900s",
                        StartDate =DateTime.ParseExact("06-15-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("06-15-2020","MM-dd-yyyy",null), EndTime = "10:00PM",
                        Location = "Solon", EventType = eventtypes.Single(e => e.EventName == "Auction"), OrganizerName = "Saleby's",
                        Number = "330-888-8867", MaxTickets = 25, TicketsAvailable = 25},


                    new Event { Title = "Military surplus Auction", Description = "Win some old rations",
                        StartDate =DateTime.ParseExact("07-18-2019","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("07-20-2019","MM-dd-yyyy",null), EndTime = "9:00PM",
                        Location = "Solon", EventType = eventtypes.Single(e => e.EventName == "Auction"), OrganizerName = "Saleby's",
                        Number = "330-888-8867", MaxTickets = 35, TicketsAvailable = 35},

                //Sale

                    
                    new Event { Title = "Amazon surplus sale", Description = "Buy refunded amazon items",
                        StartDate =DateTime.ParseExact("06-10-2019","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("06-11-2019","MM-dd-yyyy",null), EndTime = "7:00PM",
                        Location = "Solon", EventType = eventtypes.Single(e => e.EventName == "Sale"), OrganizerName = "Saleby's",
                        Number = "330-888-8868", MaxTickets = 15, TicketsAvailable = 15},

                    new Event { Title = "Vintage Soda Sale", Description = "Buy vintage sode from the 1900s",
                        StartDate =DateTime.ParseExact("06-15-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("06-15-2020","MM-dd-yyyy",null), EndTime = "10:00PM",
                        Location = "Solon", EventType = eventtypes.Single(e => e.EventName == "Sale"), OrganizerName = "Saleby's",
                        Number = "330-888-8868", MaxTickets = 25, TicketsAvailable = 25},


                    new Event { Title = "Military surplus Sale", Description = "Buy some old rations",
                        StartDate =DateTime.ParseExact("07-18-2019","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("07-20-2019","MM-dd-yyyy",null), EndTime = "9:00PM",
                        Location = "Solon", EventType = eventtypes.Single(e => e.EventName == "Sale"), OrganizerName = "Saleby's",
                        Number = "330-888-8868", MaxTickets = 35, TicketsAvailable = 35},

                
                  //Networking

                    
                    new Event { Title = "Programming networking event", Description = "Python networking",
                        StartDate =DateTime.ParseExact("08-13-2021","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("08-13-2021","MM-dd-yyyy",null), EndTime = "12:00PM",
                        Location = "Twinsburg", EventType = eventtypes.Single(e => e.EventName == "Convention"), OrganizerName = "Meet's",
                        Number = "330-888-8869", MaxTickets = 105, TicketsAvailable = 105},


                    new Event { Title = "Anime networking event", Description = "Anime Networking",
                        StartDate =DateTime.ParseExact("08-13-2021","MM-dd-yyyy",null),
                        StartTime = "1:00PM", EndDate=DateTime.ParseExact("08-14-2021","MM-dd-yyyy",null), EndTime = "2:00PM",
                        Location = "Twinsburg", EventType = eventtypes.Single(e => e.EventName == "Convention"), OrganizerName = "Meet's",
                        Number = "330-888-8869", MaxTickets = 15, TicketsAvailable = 15},


                    new Event { Title = "Canon networking event", Description = "Photography networking event",
                        StartDate =DateTime.ParseExact("08-15-2021","MM-dd-yyyy",null),
                        StartTime = "1:00PM", EndDate=DateTime.ParseExact("08-15-2021","MM-dd-yyyy",null), EndTime = "3:00PM",
                        Location = "Twinsburg", EventType = eventtypes.Single(e => e.EventName == "Convention"), OrganizerName = "Meet's",
                        Number = "330-888-8869", MaxTickets = 5, TicketsAvailable = 5},   
                    
                 //Convention

                    
                    new Event { Title = "Py-con", Description = "Python Convention",
                        StartDate =DateTime.ParseExact("08-13-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("08-13-2020","MM-dd-yyyy",null), EndTime = "12:00PM",
                        Location = "Twinsburg", EventType = eventtypes.Single(e => e.EventName == "Convention"), OrganizerName = "Meet's",
                        Number = "330-888-8870", MaxTickets = 105, TicketsAvailable = 105},


                    new Event { Title = "Colossal con", Description = "Anime Convention",
                        StartDate =DateTime.ParseExact("08-14-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("08-14-2020","MM-dd-yyyy",null), EndTime = "12:00PM",
                        Location = "Twinsburg", EventType = eventtypes.Single(e => e.EventName == "Convention"), OrganizerName = "Meet's",
                        Number = "330-888-8870", MaxTickets = 15, TicketsAvailable = 15},


                    new Event { Title = "Canon Con", Description = "Photo Convention",
                        StartDate =DateTime.ParseExact("08-15-2020","MM-dd-yyyy",null),
                        StartTime = "6:00PM", EndDate=DateTime.ParseExact("08-15-2020","MM-dd-yyyy",null), EndTime = "12:00PM",
                        Location = "Twinsburg", EventType = eventtypes.Single(e => e.EventName == "Convention"), OrganizerName = "Meet's",
                        Number = "330-888-8870", MaxTickets = 5, TicketsAvailable = 5},

                //Film

                    
                    new Event { Title = "DC Hero Movie", Description = "Man bat and the Jokester",
                        StartDate =DateTime.ParseExact("05-03-2020","MM-dd-yyyy",null),
                        StartTime = "10:00PM", EndDate=DateTime.ParseExact("05-03-2020","MM-dd-yyyy",null), EndTime = "12:00PM",
                        Location = "Akron", EventType = eventtypes.Single(e => e.EventName == "Film"), OrganizerName = "ABC",
                        Number = "330-888-8871", MaxTickets = 55, TicketsAvailable = 55},


                    new Event { Title = "Marvel Hero Movie", Description = "Steel Man",
                        StartDate =DateTime.ParseExact("05-06-2020","MM-dd-yyyy",null),
                        StartTime = "10:00PM", EndDate=DateTime.ParseExact("05-06-2020","MM-dd-yyyy",null), EndTime = "12:00PM",
                        Location = "Akron", EventType = eventtypes.Single(e => e.EventName == "Film"), OrganizerName = "ABC",
                        Number = "330-888-8871", MaxTickets = 55, TicketsAvailable = 55},


                    new Event { Title = "Didnee Movie", Description = "Princess movie",
                        StartDate =DateTime.ParseExact("05-07-2020","MM-dd-yyyy",null),
                        StartTime = "10:00PM", EndDate=DateTime.ParseExact("05-07-2020","MM-dd-yyyy",null), EndTime = "12:00PM",
                        Location = "Akron", EventType = eventtypes.Single(e => e.EventName == "Film"), OrganizerName = "ABC",
                        Number = "330-888-8871", MaxTickets = 55, TicketsAvailable = 55},

                  //Food

                    new Event { Title = "Indian Food", Description = "",
                        StartDate =DateTime.ParseExact("05-04-2020","MM-dd-yyyy",null),
                        StartTime = "1:00PM", EndDate=DateTime.ParseExact("05-04-2020","MM-dd-yyyy",null), EndTime = "8:00PM",
                        Location = "Aurora", EventType = eventtypes.Single(e => e.EventName == "Film"), OrganizerName = "Indian Restaurant",
                        Number = "330-888-8872", MaxTickets = 35, TicketsAvailable = 35},


                    new Event { Title = "Thai Food", Description = "",
                        StartDate =DateTime.ParseExact("05-20-2020","MM-dd-yyyy",null),
                        StartTime = "1:00PM", EndDate=DateTime.ParseExact("05-20-2020","MM-dd-yyyy",null), EndTime = "8:00PM",
                        Location = "Aurora", EventType = eventtypes.Single(e => e.EventName == "Film"), OrganizerName = "Thai Restaurant",
                        Number = "330-888-8873", MaxTickets = 35, TicketsAvailable = 35},


                    new Event { Title = "Chinese Food", Description = "",
                        StartDate =DateTime.ParseExact("05-20-2020","MM-dd-yyyy",null),
                        StartTime = "1:00PM", EndDate=DateTime.ParseExact("05-20-2020","MM-dd-yyyy",null), EndTime = "8:00PM",
                        Location = "Aurora", EventType = eventtypes.Single(e => e.EventName == "Film"), OrganizerName = "Chinese Restaurant",
                        Number = "330-888-8873", MaxTickets = 35, TicketsAvailable = 35},

              //Religious

                    
                    new Event { Title = "Religious Event 1" , Description = "Nondescript",
                        StartDate =DateTime.ParseExact("05-03-2020","MM-dd-yyyy",null),
                        StartTime = "1:00PM", EndDate=DateTime.ParseExact("05-03-2020","MM-dd-yyyy",null), EndTime = "8:00PM",
                        Location = "Bedford", EventType = eventtypes.Single(e => e.EventName == "Religious"), OrganizerName = "Nondescript church",
                        Number = "330-888-8874", MaxTickets = 35, TicketsAvailable = 35},

                    new Event { Title = "Religious Event 2" , Description = "Nondescript",
                        StartDate =DateTime.ParseExact("05-04-2020","MM-dd-yyyy",null),
                        StartTime = "1:00PM", EndDate=DateTime.ParseExact("05-04-2020","MM-dd-yyyy",null), EndTime = "8:00PM",
                        Location = "Bedford", EventType = eventtypes.Single(e => e.EventName == "Religious"), OrganizerName = "Nondescript church",
                        Number = "330-888-8874", MaxTickets = 35, TicketsAvailable = 35},

                    new Event { Title = "Religious Event 3" , Description = "Nondescript",
                        StartDate =DateTime.ParseExact("05-05-2020","MM-dd-yyyy",null),
                        StartTime = "1:00PM", EndDate=DateTime.ParseExact("05-05-2020","MM-dd-yyyy",null), EndTime = "8:00PM",
                        Location = "Bedford", EventType = eventtypes.Single(e => e.EventName == "Religious"), OrganizerName = "Nondescript church",
                        Number = "330-888-8874", MaxTickets = 35, TicketsAvailable = 35},

            }.ForEach(a => context.Events.Add(a));
        }
    }
}