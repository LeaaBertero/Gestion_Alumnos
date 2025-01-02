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
    [Index(nameof(EvaluacionId), Name = "NotasDeEvaluacionIDX", IsUnique = false)]
    [Index(nameof(CursadoMateriaId), Name = "NotasDeAlumnoEnMateriaIDX", IsUnique = false)]

    public class Nota : EntityBase
    {
        public int EvaluacionId { get; set; }
        public Evaluacion Evaluacion { get; set; }

        [Required(ErrorMessage = "La calificación es obligatoria")]
        [MaxLength(60, ErrorMessage = "Máximo número de caracteres {1}.")]
        public int ValorNota { get; set; }

        [Required(ErrorMessage = "La asistencia es obligatoria")]
        [MaxLength(60, ErrorMessage = "Máximo número de caracteres {1}.")]
        public char Asistencia { get; set; }
        
        public int CursadoMateriaId { get; set; }
        public CursadoMateria CursadoMateria { get; set; }
    }
}


       
       
        
        
        
