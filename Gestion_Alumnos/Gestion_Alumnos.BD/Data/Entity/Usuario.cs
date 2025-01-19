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
    [Index(nameof(PersonaId), Name = "PersonaId", IsUnique = true)]
    [Index(nameof(Email), nameof(Contrasena), nameof(Estado),
    Name = "Email_Contrasena_Estado", IsUnique = false)]
    
    public class Usuario : EntityBase
    {
       
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        [Required(ErrorMessage = "Ingrese el correo electrónico")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese la contraseña")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Contrasena { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        public bool Estado { get; set; }

        public List<Alumno> Alumnos { get; set; }
    }
}
