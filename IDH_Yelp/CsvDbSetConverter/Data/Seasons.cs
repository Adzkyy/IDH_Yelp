using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDbSetConverter.Data
{
    public class Seasons
    {
        [Key]
        public string Year { get; set; }
        public string Url { get; set; }
    }
}
