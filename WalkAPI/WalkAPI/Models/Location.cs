using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Device.Location;
using System.ComponentModel.DataAnnotations.Schema;


namespace WalkAPI.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        [Required]
        public string Name { get; set; }
        //public GeoCoordinate Stop { get; set; }






    }
}
