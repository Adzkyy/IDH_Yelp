using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data
{
    public class Status
    {
        [Key]
        public string StatusId { get; set; }
        public string Name { get; set; }
    }
}
