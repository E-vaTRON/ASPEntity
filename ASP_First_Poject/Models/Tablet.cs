using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_First_Poject.Models
{
    public class Tablet : Device
    {
        [Key]
        public int TabletID { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int Ram { get; set; }
        public int Storage { get; set; }
        public int ScreenSize { get; set; }
        public Camera MainCamera { get; set; }
        public Camera SelfieCamera { get; set; }
        public string Speaker { get; set; }
        public double Battery { get; set; }
    }
}
