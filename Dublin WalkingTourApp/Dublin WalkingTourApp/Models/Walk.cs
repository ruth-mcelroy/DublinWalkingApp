using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dublin_WalkingTourApp.Models
{
    [XmlType("Walk")]
    public class Walk
    {
        [XmlElement("WalkID")]
        public int WalkID { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
