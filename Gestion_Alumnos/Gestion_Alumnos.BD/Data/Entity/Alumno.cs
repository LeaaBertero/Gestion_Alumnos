﻿using Gestion_Alumnos.BD.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Alumnos.BD.Data.Entidades
{
   [Index(nameof(UsuarioId), Name = "UsuarioId", IsUnique = true)]
   [Index(nameof(Nombre), nameof(Sexo), nameof(FechaNacimiento),
   nameof(Edad), nameof(CUIL), nameof(Pais), nameof(Provincia), nameof(TituloBase), nameof(CUS), nameof(Estado),
   Name = "Nombre_Sexo_FechaNacimiento_Edad_CUIL_Pais_Provincia_TituloBase_CUS_Estado", IsUnique = false)]
    public class Alumno : EntityBase
    {
        //clave primaria de la tabla
        public int AlumnoId { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
        //clave foranea
        //#region clave primaria Usuario
        //public Usuario Usuario { get; set; }
        //#endregion



        public Carrera Carrera { get; set; }
        public int CarreraId { get; set; }
        

        //Atributos de la tabla
        #region Atributos
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Nombre { get; set; } //modificado con signo de pregunta
        
        
        [Required(ErrorMessage = "Sexo")]
        [MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Sexo { get; set; } //modificado con signo de pregunta
        

        
        [Required(ErrorMessage = "Ingrese la fecha de nacimiento")]
        public DateOnly FechaNacimiento { get; set; }
        

        
        [Required(ErrorMessage = "Ingrese la edad")]
        public int Edad { get; set; }
        

        
        [Required(ErrorMessage = "Ingrese el  Nro  de Cuil")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string CUIL { get; set; } //modificado con signo de pregunta
        

        [Required(ErrorMessage = "Nacionalidad")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Pais { get; set; } //modificado con signo de pregunta
        
        
        [Required(ErrorMessage = "Provincia")]
        [MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Provincia { get; set; } //modificacion con signo de pregunta


        [Required(ErrorMessage = "Titulo Base")] //corregir el titulo
        [MaxLength(60, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string TituloBase { get; set; }
        
        
        [Required(ErrorMessage = "CUS")]
        [MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string CUS { get; set; }
      

        
        [Required(ErrorMessage = "El estado de la materia es obligatorio")]
        public string Estado { get; set; } //modificado con signo de pregunta




        


        #region Listas de certificados
        public List<CertificadoAlumno> CertificadosAlumno { get; set; } = new List<CertificadoAlumno>();
        #endregion

        #region Lista de alumnos que cursan la materia
        public List<CursadoMateria> MateriasCursadas { get; set; } = new List<CursadoMateria>();
        #endregion

        #endregion
    }

}

        
