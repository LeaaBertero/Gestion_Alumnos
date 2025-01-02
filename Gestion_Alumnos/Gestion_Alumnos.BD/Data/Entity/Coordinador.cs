using Gestion_Alumnos.BD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Alumnos.BD.Data.Entidades
{
    public class Coordinador : EntityBase
    {
       
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

       
        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }

        [Required(ErrorMessage = "El estado del coordinador es obligatorio")]
       
        public bool Estado { get; set; } = true; 
    }
}
