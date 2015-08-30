using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublin_WalkingTourApp.Models
{
    class Audio
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte[] File { get; set; }
    }
}
