using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WalkAPI.Models
{

    public class MobileServiceContext : DbContext
    {


        public MobileServiceContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<MobileServiceContext>(new DropCreateDatabaseAlways<MobileServiceContext>());
        }
        public System.Data.Entity.DbSet<WebServiceWalkingApp.Models.Walk> Walks { get; set; }

        public System.Data.Entity.DbSet<WebServiceWalkingApp.Models.Audio> Audios { get; set; }

        public System.Data.Entity.DbSet<WebServiceWalkingApp.Models.Location> Locations { get; set; }
    }

}
