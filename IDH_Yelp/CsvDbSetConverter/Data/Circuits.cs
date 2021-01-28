using System.ComponentModel.DataAnnotations;

namespace CsvDbSetConverter.Data
{
    public class Circuits
    {
        [Key]
        public string CircuitId { get; set; }
        public string CircuitRef { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Alt { get; set; }
        public string Url { get; set; }
    }
}
