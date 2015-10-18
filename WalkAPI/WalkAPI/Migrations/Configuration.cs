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
            AutomaticMigrationsEnabled = true;
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
               new Location { LocationID = 1, WalkInfo = context.Walks.FirstOrDefault(w => w.WalkID == 1), Name = "Number 42", Order = 1, AudioInfo = context.Audios.First(a => a.AudioID == 1) },
               new Location { LocationID = 2, WalkInfo = context.Walks.FirstOrDefault(w => w.WalkID == 1), Name = "Quote", Order = 2, AudioInfo = context.Audios.First(a => a.AudioID == 2) },
               new Location { LocationID = 3, WalkInfo = context.Walks.FirstOrDefault(w => w.WalkID == 1), Name = "Lower O'Connell", Order = 3, AudioInfo = context.Audios.First(a => a.AudioID == 3) },
               new Location { LocationID = 4, WalkInfo = context.Walks.FirstOrDefault(w => w.WalkID == 1), Name = "GPO", Order = 4, AudioInfo = context.Audios.First(a => a.AudioID == 4) },
               new Location { LocationID = 5, WalkInfo = context.Walks.FirstOrDefault(w => w.WalkID == 1), Name = "The Spire", Order = 5, AudioInfo = context.Audios.First(a => a.AudioID == 5) },
               new Location { LocationID = 6, WalkInfo = context.Walks.FirstOrDefault(w => w.WalkID == 1), Name = "Nelson's Column", Order = 6, AudioInfo = context.Audios.First(a => a.AudioID == 6) },
               new Location { LocationID = 7, WalkInfo = context.Walks.FirstOrDefault(w => w.WalkID == 1), Name = "World Boxing Championship", Order = 7, AudioInfo = context.Audios.First(a => a.AudioID == 7) },
               new Location { LocationID = 8, WalkInfo = context.Walks.FirstOrDefault(w => w.WalkID == 1), Name = "Daniel O'Connell", Order = 8, AudioInfo = context.Audios.First(a => a.AudioID == 8) }
             );




            
        }
    }
}
