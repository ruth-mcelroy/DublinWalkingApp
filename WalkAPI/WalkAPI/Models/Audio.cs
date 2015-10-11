﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkAPI.Models
{
    public class Audio
    {
        [Key]
        public int AudioID { get; set; }
        [Required]
        public string Name { get; set; }
        public byte[] File { get; set; }

    }
}
