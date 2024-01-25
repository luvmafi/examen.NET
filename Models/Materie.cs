using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examenDAW.Models
{
    public class Materie
    {
        [Key]
        public int Id { get; set; }

        public string Nume { get; set; }

        public virtual ICollection<MateriiProfesori>? Profesori { get; set; }
    }
}
