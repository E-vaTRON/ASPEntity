using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_First_Poject.Models
{
    public class Laptop : Device
    {
        [Key]
        public int LaptopID { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int Ram { get; set; }
        public int Storage { get; set; }
        public int ScreenSize { get; set; }
        public Camera Camera { get; set; }
        public string Speaker { get; set; }
        public double Battery { get; set; }
        public string Touchpad { get; set;  }
        public string Fingersensor { get; set; }

    }
}
