using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WalkAPI.Models
{

    public class WalkContext : DbContext
    {


        public WalkContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<WalkContext>(new DropCreateDatabaseAlways<WalkContext>());
        }
        public System.Data.Entity.DbSet<WalkAPI.Models.Walk> Walks { get; set; }

        public System.Data.Entity.DbSet<WalkAPI.Models.Audio> Audios { get; set; }

        public System.Data.Entity.DbSet<WalkAPI.Models.Location> Locations { get; set; }
    }

}
