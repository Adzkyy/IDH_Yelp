using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDbSetConverter.Data
{
    public class Attributes
    {
        [Key]
        public int Id  { get; set; }
        public string BusinessAcceptsCreditCards { get; set; }
        public string BikeParking { get; set; }
        public string GoodForKids { get; set; }
        public string BusinessParking { get; set; }
        public string ByAppointmentOnly { get; set; }
        public string RestaurantsPriceRange2 { get; set; }
    }
}
