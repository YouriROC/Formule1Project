using System.ComponentModel.DataAnnotations;

namespace F1Lib.Models
{
    public class Team
    {
        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]

        [Display(Name = "Naam")]
        public string Name { get; set; } = string.Empty;
        

        public string? Description { get; set; } = string.Empty;

        [DataType(DataType.Url)]
        [StringLength(250, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]
        [Display(Name = "Wikipedia")]
        public string? Wiki { get; set; } = string.Empty;

        [Display(Name = "Land")]
        public Country? Country { get; set; }

        public ICollection<Result>? Races { get; set; } 
    }
}
