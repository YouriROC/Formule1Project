using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1Lib.Models
{
    public class Country
    {
        [RegularExpression("[A-Z]{2}", ErrorMessage = "Country code moet bestaan uit 2 hoofdletters")]
        [Column(TypeName = "char")]
        [Key]
        [Display(Name = "Landcode")]
        [StringLength(2)]

        public string? CountryCode { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Land")]
        [StringLength(2,ErrorMessage = "Maximumlengte voor {0} is {1} tekens")]

        public string? CountryName { get; set; } = string.Empty;
        public ICollection<Driver>? Drivers { get; set; } 
        public ICollection<Team>? Teams { get; set; } 
        public ICollection<Circuit>? Circuits { get; set; } 
    }
}
