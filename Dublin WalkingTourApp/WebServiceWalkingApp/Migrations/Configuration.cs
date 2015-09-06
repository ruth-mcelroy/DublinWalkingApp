namespace WebServiceWalkingApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Device.Location;
    using System.Linq;
    using WebServiceWalkingApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebServiceWalkingApp.Models.MobileServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebServiceWalkingApp.Models.MobileServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            if (System.Diagnostics.Debugger.IsAttached == false)
                System.Diagnostics.Debugger.Launch();
            
            GeoCoordinate g1 = new GeoCoordinate(53.347921, -6.259559);
            Audio a1 = new Audio { Name = "test" };

            context.Locations.AddOrUpdate(
              l => l.Name,
              new Location { Name = "Daniel O'Connell", AudioInfo = a1 }
              
            );
            
        }
    }
}
