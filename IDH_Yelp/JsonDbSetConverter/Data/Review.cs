using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace JsonDbSetConverter.Data
{
    public class Review
    {

        [Key]
        public string review_id { get; set; }
        public string user_id { get; set; }
        public string business_id { get; set; }
        public double stars { get; set; }
        public int useful { get; set; }
        public int funny { get; set; }
        public int cool { get; set; }
        [JsonIgnore]
        public string text { get; set; }
        public string date { get; set; }
    }
}
