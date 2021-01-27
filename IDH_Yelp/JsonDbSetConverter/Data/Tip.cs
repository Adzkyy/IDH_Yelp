using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDbSetConverter.Data
{
    public class Tip
    {
        public string user_id { get; set; }
        public string business_id { get; set; }
        public string text { get; set; }
        public string date { get; set; }
        public int compliment_count { get; set; }
    }
}
