using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examenDAW.Models
{
    public class MateriiProfesori
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? ProfesorId { get; set; }

        public int? MaterieId { get; set; }

        public virtual Profesor Prof {  get; set; }

        public virtual Materie Mat { get; set; }
    }
}
