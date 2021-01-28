using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDbSetConverter.Data
{
    public class Result
    {
        [Key]
        public string ResultId { get; set; }
        public string RaceId { get; set; }
        public string DriverId { get; set; }
        public string ConstructorId { get; set; }
        public string Number { get; set; }
        public string Grid { get; set; }
        public string Position { get; set; }
        public string PositionText { get; set; }
        public string PositionOrder { get; set; }
        public string Points { get; set; }
        public string Laps { get; set; }
        public string Time { get; set; }
        public string Milliseconds { get; set; }
        public string FastestLap { get; set; }
        public string Rank { get; set; }
        public string FastestLapTime { get; set; }
        public string FastestLapSpeed { get; set; }
        public string StatusId { get; set; }
    }
}
