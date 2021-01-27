using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDbSetConverter.Data
{
    public class Business
    {
        public string business_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double stars { get; set; }
        public int review_count { get; set; }
        public int is_open { get; set; }
        public Attributes attributes { get; set; }
        public string categories { get; set; }
        public Hours hours { get; set; }
    }
}
