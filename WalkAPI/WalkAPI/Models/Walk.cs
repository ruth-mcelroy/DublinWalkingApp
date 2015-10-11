using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkAPI.Models
{
    public class Walk
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WalkID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Location> Stops { get; set; }
    }
}
