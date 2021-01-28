using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDbSetConverter.Data
{
    public class LapTimes
    {
        [Key] 
        public int Id { get; set; }
        public string RaceId { get; set; }
        public string DriverId { get; set; }
        public string Lap { get; set; }
        public string Position { get; set; }
        public string Time { get; set; }
        public string Milliseconds { get; set; }
    }
}
