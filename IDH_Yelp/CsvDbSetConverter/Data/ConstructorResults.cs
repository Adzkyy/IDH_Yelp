using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDbSetConverter.Data
{
    public class ConstructorResults
    {
        [Key]
        public string ConstructorResultsId { get; set; }
        public string RaceId { get; set; }
        public string ConstructorId { get; set; }
        public string Points { get; set; }
        public string Status { get; set; }
    }
}
