using System.ComponentModel.DataAnnotations;

namespace DEMO.Webforms.Models
{
    public class Band
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string BandName { get; set; }
        [Required, StringLength(10000), Display(Name = "Band Biography"), DataType(DataType.MultilineText)]
        public string Bio { get; set; }
    }
}