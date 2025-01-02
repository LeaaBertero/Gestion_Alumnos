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
    [Index(nameof(MateriaEnPlanEstudioId), nameof(Sede), nameof(Horario), nameof(AnnoCicloLectivo), Name = "InscripcionCarrera_UQ", IsUnique = true)]
    [Index(nameof(MateriaEnPlanEstudioId), nameof(ProfesorId), Name = "MateriasQueDaUnProfeIDX", IsUnique = false)]
    
    public class Turno : EntityBase
    {
      
        public int? ProfesorId { get; set; } 
        public Profesor? Profesor { get; set; }

        
        
        [Required(ErrorMessage = "La sede es obligatoria")]
        [MaxLength(45, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Sede { get; set; }

        
        
        [Required(ErrorMessage = "El horario es obligatorio")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Horario { get; set; }

        
        
        [Required(ErrorMessage = "El ciclo lectivo es obligatorio")]
        [MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}.")]
        public int AnnoCicloLectivo { get; set; } 


        
      
        
        
        public List<CursadoMateria>? AlumnosCursando { get; set; } = new List<CursadoMateria>();
        public List<Clase>? Clases { get; set; } = new List<Clase>();




        public int MateriaEnPlanEstudioId { get; set; }
        public MateriaEnPlanEstudio MateriaEnPlanEstudio { get; set; }
    }
}
