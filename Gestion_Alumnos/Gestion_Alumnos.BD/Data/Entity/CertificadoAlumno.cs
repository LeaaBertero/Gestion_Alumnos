using Gestion_Alumnos.BD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proyecto_Alumnos.BD.Data.Entidades
{
   

    public class CertificadoAlumno : EntityBase
    {
        public int AlumnoId { get; set; }

        [Required(ErrorMessage = "El campo fecha de emisión es obligatorio")]
        public Alumno Alumno { get; set; }

        [Required(ErrorMessage = "El campo fecha de emisión es obligatorio")]
        public DateTime FechaEmision { get; set; }
    }
}
        
