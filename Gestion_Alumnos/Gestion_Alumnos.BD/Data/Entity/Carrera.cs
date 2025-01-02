using Gestion_Alumnos.BD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Alumnos.BD.Data.Entidades
{
    public class Carrera : EntityBase
    {

        public int CarrereId { get; set; }
        [Required(ErrorMessage = "El nombre de la carrera es obligatoria")]
        [MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La duración de la carrera es obligatoria")]
        [MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string DuracionCarrera { get; set; } 


        [Required(ErrorMessage = "La modalidad de la carrera es obligatoria")]
        [MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Modalidad { get; set; } 

        public List<InscripcionCarrera> InscripcionesCarrera { get; set; } = new List<InscripcionCarrera>();
    }
}
