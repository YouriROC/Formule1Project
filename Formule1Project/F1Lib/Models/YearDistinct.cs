using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Lib.Models
{
    public class YearDistinct
    {
        [Key]
        [Display(Name = "Jaartal")]
        public int Years { get; set; }

        [Display(Name = "Totaal aantal races")]
        public int Totalraces { get; set; }
    }
}
