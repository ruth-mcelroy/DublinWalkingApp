using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceWalkingApp.Models
{
    public class Audio
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public byte[] File { get; set; }
        
    }
}
