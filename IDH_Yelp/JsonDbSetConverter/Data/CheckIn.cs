using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDbSetConverter.Data
{
    public class CheckIn
    {
        [Key]
        public int Id { get; set; }
        public string business_id { get; set; }
        public string date { get; set; }
    }
}
