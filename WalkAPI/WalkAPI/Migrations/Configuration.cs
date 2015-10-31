namespace WalkAPI.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.IO;
    using WalkAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WalkAPI.Models.WalkContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WalkAPI.Models.WalkContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

             context.Audios.AddOrUpdate(
             p => p.AudioID,
              new Audio { AudioID = 1, Name = "Number 42", AudioFile = File.ReadAllBytes( "C:/WalkFiles/Number42.mp3") },
              new Audio { AudioID = 2, Name = "Quote", AudioFile = File.ReadAllBytes("C:/WalkFiles/Quote.mp3") },
              new Audio { AudioID = 3, Name = "Lower O'Connell", AudioFile = File.ReadAllBytes("C:/WalkFiles/LowerOConnell.mp3") },
              new Audio { AudioID = 4, Name = "GPO", AudioFile = File.ReadAllBytes("C:/WalkFiles/GPO.mp3") },
              new Audio { AudioID = 5, Name = "The Spire", AudioFile = File.ReadAllBytes("C:/WalkFiles/Spire.mp3") },
              new Audio { AudioID = 6, Name = "Nelson's Column", AudioFile = File.ReadAllBytes("C:/WalkFiles/NelsonsColumn.mp3") },
              new Audio { AudioID = 7, Name = "World Boxing Championship", AudioFile = File.ReadAllBytes("C:/WalkFiles/WorldBoxingChampionship.mp3") },
              new Audio { AudioID = 8, Name = "Daniel O'Connell", AudioFile = File.ReadAllBytes("C:/WalkFiles/DanielOConnellAndRenaming.mp3") }
            );

             context.Walks.AddOrUpdate(
               p => p.WalkID,
               new Walk { WalkID = 1, Name = "O'Connell", Description = "A walk along Ireland's most historic street. This walk includes information on the history and architecture of O'Connell street." }
             );


             context.Locations.AddOrUpdate(
               p => p.LocationID,
               new Location { LocationID = 1, Name = "Number 42", Order =1 },
               new Location { LocationID = 2, Name = "Quote", Order = 2 },
               new Location { LocationID = 3, Name = "Lower O'Connell", Order = 3 },
               new Location { LocationID = 4, Name = "GPO", Order = 4 },
               new Location { LocationID = 5, Name = "The Spire", Order = 5 },
               new Location { LocationID = 6, Name = "Nelson's Column", Order = 6 },
               new Location { LocationID = 7, Name = "World Boxing Championship", Order = 7 },
               new Location { LocationID = 8, Name = "Daniel O'Connell", Order = 8 }
             );




            
        }
    }
}
