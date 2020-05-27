using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_First_Poject.Models
{
    public class MechanicalKeyboard : Device
    {
        [Key]
        public string Switchtype { get; set; }
        public string SwitchBrand { get; set; }
        public string LedRGB { get; set; }
        public string Battery { get; set; }
        public string Keycap { get; set; }
        public float Bluetooth { get; set; }
        public string ConnectingGate { get; set; }
    }
}
