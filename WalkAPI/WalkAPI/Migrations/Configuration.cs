namespace WebServiceWalkingApp.Migrations
{
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
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
            if (System.Diagnostics.Debugger.IsAttached == false)
                System.Diagnostics.Debugger.Launch();


            Audio a1 = new Audio { AudioID= 1, Name = "test" };

            context.Audios.AddOrUpdate(
              l => l.Name,
              new Audio { Name = "Test11" }
              );

            //using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
            //{
            //    byte[] bytes = br.ReadBytes((int)FileUpload1.PostedFile.InputStream.Length);
            //    string strConnString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //    using (SqlConnection con = new SqlConnection(strConnString))
            //    {
            //        using (SqlCommand cmd = new SqlCommand())
            //        {
            //            cmd.CommandText = "insert into tblFiles(Name, ContentType, Data) values (@Name, @ContentType, @Data)";
            //            cmd.Parameters.AddWithValue("@Name", Path.GetFileName(FileUpload1.PostedFile.FileName));
            //            cmd.Parameters.AddWithValue("@ContentType", "audio/mpeg3");
            //            cmd.Parameters.AddWithValue("@Data", bytes);
            //            cmd.Connection = con;
            //            con.Open();
            //            cmd.ExecuteNonQuery();
            //            con.Close();
            //        }
            //}
            //}
        }
    }
}
