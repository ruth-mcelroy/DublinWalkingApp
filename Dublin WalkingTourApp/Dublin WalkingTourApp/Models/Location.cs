using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublin_WalkingTourApp.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        //public GeoCoordinate Stop { get; set; }
    }
}
