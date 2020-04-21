﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class EventDbContext : DbContext
    {

        public static object Event { get; internal set; }
       public System.Data.Entity.DbSet<EventApplication.Models.Event> Events { get; set; }

        public System.Data.Entity.DbSet<EventApplication.Models.EventType> EventTypes { get; set; }

        public System.Data.Entity.DbSet<EventApplication.Models.Order> Orders { get; set; }

        //public System.Data.Entity.DbSet<MvcMusicStore.Models.Order> Orders { get; set; }

        //public System.Data.Entity.DbSet<MvcMusicStore.Models.Cart> Carts { get; set; }
    }
}