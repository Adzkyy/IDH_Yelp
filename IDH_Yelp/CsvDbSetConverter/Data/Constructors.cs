using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDbSetConverter.Data
{
    public class Constructors
    {
        [Key]
        public string ConstructorId { get; set; }
        public string ConstructorRef { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Url { get; set; }
    }
}
