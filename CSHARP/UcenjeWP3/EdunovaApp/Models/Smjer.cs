using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaApp.Models
{
    public class Smjer:Entitet
    {
        public string? Naziv { get; set; }
        public int? Trajanje { get; set; }
        public decimal? Cijena { get; set; }

        [Column("vaucer")] 
        public bool? Veriificiran { get; set; }
    }
}
