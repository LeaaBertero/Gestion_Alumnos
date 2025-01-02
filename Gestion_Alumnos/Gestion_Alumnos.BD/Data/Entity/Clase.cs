﻿using Gestion_Alumnos.BD.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proyecto_Alumnos.BD.Data.Entidades
{
    [Index(nameof(TurnoId), Name = "ClasesDeUnTurnoIDX", IsUnique = false)]
    [Index(nameof(TurnoId), nameof(Fecha), Name = "Clases_UQ", IsUnique = true)]

    public class Clase : EntityBase
    {
        [Required(ErrorMessage = "El turno es obligatorio")]
        public int TurnoId { get; set; }
        public Turno Turno { get; set; }

        [Required(ErrorMessage = "La fecha de clase es obligatoria")]
        public DateTime Fecha { get; set; }

    }
}
