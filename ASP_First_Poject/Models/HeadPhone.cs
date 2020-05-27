using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_First_Poject.Models
{
    public class HeadPhone : Device
    {
        [Key]
        public int HeadPhoneID { get; set; }
        public string LedRGB { get; set; }
        public string Battery { get; set; }
        public string Speaker { get; set; }
        public float Bluetooth { get; set; }
        public string ConnectingGate { get; set; }
    }
}
