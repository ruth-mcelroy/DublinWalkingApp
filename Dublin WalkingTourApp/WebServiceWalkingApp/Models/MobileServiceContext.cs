using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Tables;
using WebServiceWalkingApp.DataObjects;

namespace WebServiceWalkingApp.Models
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
