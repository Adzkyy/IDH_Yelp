using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDbSetConverter.Data
{
    public class Races
    {
        [Key]
        public string RaceId { get; set; }
        public string Year { get; set; }
        public string Round { get; set; }
        public string CircuitId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Url { get; set; }
    }
}
