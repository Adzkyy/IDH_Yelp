using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDbSetConverter.Data
{
    public class Review
    {
        public string review_id { get; set; }
        public string user_id { get; set; }
        public string business_id { get; set; }
        public int stars { get; set; }
        public int useful { get; set; }
        public int funny { get; set; }
        public int cool { get; set; }
        public string text { get; set; }
        public string date { get; set; }
    }
}
