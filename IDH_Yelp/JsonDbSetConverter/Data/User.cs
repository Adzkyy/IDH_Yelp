using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace JsonDbSetConverter.Data
{
    public class User
    {
        [Key] 
        public int Id { get; set; }
        public string user_id { get; set; }
        [JsonIgnore]
        public string name { get; set; }
        public int review_count { get; set; }
        public string yelping_since { get; set; }
        public int useful { get; set; }
        public int funny { get; set; }
        public int cool { get; set; }
        public string elite { get; set; }
        [JsonIgnore]
        public string friends { get; set; }
        public int fans { get; set; }
        public double average_stars { get; set; }
        public int compliment_hot { get; set; }
        public int compliment_more { get; set; }
        public int compliment_profile { get; set; }
        public int compliment_cute { get; set; }
        public int compliment_list { get; set; }
        public int compliment_note { get; set; }
        public int compliment_plain { get; set; }
        public int compliment_cool { get; set; }
        public int compliment_funny { get; set; }
        public int compliment_writer { get; set; }
        public int compliment_photos { get; set; }
    }
}
