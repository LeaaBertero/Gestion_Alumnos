using Gestion_Alumnos.BD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Alumnos.BD.Data.Entidades
{
    public class Correlatividad : EntityBase
    {
       
        public int MateriaEnPlanEstudioId { get; set; }
        public MateriaEnPlanEstudio MateriaEnPlanEstudio { get; set; } 

        
        public int MateriaCorrelativaId { get; set; }
        public MateriaEnPlanEstudio MateriaCorrelativa { get; set; }
    }
}
