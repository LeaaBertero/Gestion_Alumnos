using Gestion_Alumnos.BD.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Alumnos.BD.Data.Entidades
{
    //los indices de la tabla esta mal, le falta la clave primaria de la tabla (No entiendo !!!!!!!!!!!!)
    [Index(nameof(Nombre), nameof(ResolucionMinisterial), Name = "Materia_UQ", IsUnique = true)]
    [Index(nameof(Nombre), Name = "Nombre_Formato_Formacion_ResolucionMinisterial_Anno", IsUnique = false)]
   
    public class Materia : EntityBase
    {
        [Required(ErrorMessage = "El nombre de la materia es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El formato de la materia es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? Formato { get; set; }

        [Required(ErrorMessage = "La formación de la materia es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? Formacion { get; set; }

        [Required(ErrorMessage = "La resolución ministerial de la materia es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? ResolucionMinisterial { get; set; }

        [Required(ErrorMessage = "El año de la materia es obligatorio")]
        public int Anno { get; set; }
    }
}
