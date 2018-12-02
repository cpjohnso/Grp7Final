using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace IEXTrading.Models
{
    public class Headline
    {
        public string datetime { get; set; }
        public string source { get; set; }
        public string summary { get; set; }
        [Key]
        public string url { get; set; }
    }
}
