
using System.ComponentModel.DataAnnotations;

namespace F1Lib.Models
{
    public class Circuit
    {

        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]
        public string Name { get; set; } = string.Empty;
        public string? description { get; set; }
        [Display(Name = "Lat")]
        public double? Latitude { get; set; }
        [Display(Name = "Lon")]
        public double? Longitude { get; set; }
        [Display(Name = "Wikipedia")]
        [DataType(DataType.Url)]
        [StringLength(250, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]
        public string? Wiki { get; set; } = string.Empty;
        public Country? Country { get; set; }
        public ICollection?<Result> Races { get; set; }
    }
}
