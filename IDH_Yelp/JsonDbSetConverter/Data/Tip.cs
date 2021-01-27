using System.ComponentModel.DataAnnotations;

namespace JsonDbSetConverter.Data
{
    public class Tip
    {
        [Key]
        public int Id { get; set; }
        public string user_id { get; set; }
        public string business_id { get; set; }
        public string text { get; set; }
        public string date { get; set; }
        public int compliment_count { get; set; }
    }
}
