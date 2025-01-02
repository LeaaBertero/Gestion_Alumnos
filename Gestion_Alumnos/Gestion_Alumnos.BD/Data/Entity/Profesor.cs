using Gestion_Alumnos.BD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Alumnos.BD.Data.Entidades
{
    public class Profesor : EntityBase
    {
        
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public bool Estado { get; set; } = true;
    }
}
