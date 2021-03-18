using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindMyCupCake.Models
{
    public class MyCupCake
    {
        [Key]
        public int MyCupCakeId { get; set; }
        public string travelto { get; set; }
        public string travelfrom { get; set; }
        public string TypeOfTransport { get; set; }
        public decimal PricePerKm { get; set; }
        public decimal PricePerhr { get; set; }
        public string Distance { get; set; }
        public string Duration { get; set; }
        public decimal TotalCost { get; set; }


    }
}