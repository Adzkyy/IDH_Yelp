using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDbSetConverter.Data
{
    public class Qualifying
    {
        [Key]
        public string QualifyId { get; set; }
        public string RaceId { get; set; }
        public string DriverId { get; set; }
        public string ConstructorId { get; set; }
        public string Number { get; set; }
        public string Position { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
    }
}
