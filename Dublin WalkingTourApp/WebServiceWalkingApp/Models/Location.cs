using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
//using System.Windows.Devices.Geolocation;

namespace WebServiceWalkingApp.Models
{
    public class Location
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public GeoCoordinate Stop { get; set; }
        public int Order{get;set;}
        public Audio AudioInfo { get; set; }


    }
}
