using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_First_Poject.Models
{
    public class Device
    {
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public DateTime YearManufact { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
