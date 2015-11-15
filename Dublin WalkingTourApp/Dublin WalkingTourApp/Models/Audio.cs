using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublin_WalkingTourApp.Models
{
    public class Audio
    {
        public int AudioID { get; set; }
        public string Name { get; set; }
        public byte[] AudioFile { get; set; }
    }
}
