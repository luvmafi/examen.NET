using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examenDAW.Models
{
    public class Profesor
    {
        [Key]
        public int Id { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Tip { get; set; }

        public virtual ICollection<MateriiProfesori>? Materii {  get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem>? TipToate { get; } = new List<SelectListItem>
        {
            new SelectListItem { Text = "Standard", Value = "Standard" },
            new SelectListItem { Text = "Laborant", Value = "Laborant" }
        };
    }
}
