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
   [Index(nameof(UsuarioId), Name = "UsuarioId", IsUnique = true)]
   
    public class Alumno : EntityBase
    {

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }


        public Carrera Carrera { get; set; }
        public int CarreraId { get; set; }
        

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

        [Required(ErrorMessage = "Dato obligatorio")]
        [MaxLength(16, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? FotocopiaDNI { get; set; }

        [Required(ErrorMessage = "El campo constancia es obligatorio")]
        [MaxLength(16, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? ConstanciaCUIL { get; set; } //esto es para indicar que el alumno trajo o mandó un documento virtual de la constancia de CUIL, no tiene que ver con el atributo "CUIL", el cual es el cuil real.

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? PartidaNacimiento { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? Analitico { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? FotoCarnet { get; set; }

        [Required(ErrorMessage = "Dato obligatorio")]
        [MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string CUS { get; set; }

      
        [Required(ErrorMessage = "El estado del alumno es obligatorio")]
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

        
