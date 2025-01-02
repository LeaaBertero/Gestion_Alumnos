using Gestion_Alumnos.BD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Alumnos.BD.Data.Entidades
{
    public class Alumno : EntityBase
    {
        //lave primaria de la tabla
        #region clave primaria de la tabla
        public int UsuarioId { get; set; }
        #endregion

        //clave foranea
        #region clave foranea Usuario
        public Usuario Usuario { get; set; }
        #endregion

       

        #region Clave foranea Carrera
        public Carrera Carrera { get; set; }
        #endregion

        //Atributos de la tabla
        #region Atributos
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? Nombre { get; set; } //modificado con signo de pregunta
        
        
        [Required(ErrorMessage = "Sexo")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? Sexo { get; set; } //modificado con signo de pregunta
        

        
        [Required(ErrorMessage = "Ingrese la fecha de nacimiento")]
        public DateOnly FechaNacimiento { get; set; }
        

        
        [Required(ErrorMessage = "Ingrese la edad")]
        public int Edad { get; set; }
        

        
        [Required(ErrorMessage = "Ingrese el  Nro  de Cuil")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? CUIL { get; set; } //modificado con signo de pregunta
        

        
        [Required(ErrorMessage = "Nacionalidad")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? Pais { get; set; } //modificado con signo de pregunta
        

        
        [Required(ErrorMessage = "Provincia")]
        [MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? Provincia { get; set; } //modificacion con signo de pregunta

        

       
        [Required(ErrorMessage = "Titulo Base")] //corregir el titulo
        [MaxLength(60, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? TituloBase { get; set; }
        

        
        [Required(ErrorMessage = "CUS")]
        [MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? CUS { get; set; }
      

        
        [Required(ErrorMessage = "El estado de la materia es obligatorio")]
        public string? Estado { get; set; } //modificado con signo de pregunta
        

        #region comentarios de la tabla
        //[Required(ErrorMessage = "El departamento es obligatorio")]
        //[MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        //public string? Departamento { get; set; }


        //[Required(ErrorMessage = "Dato obligatorio")]
        //[MaxLength(16, ErrorMessage = "Máximo número de caracteres {1}.")]
        //public string? FotocopiaDNI { get; set; }

        //[Required(ErrorMessage = "La constancia de constancia de cuil es obligatoria")]
        //[MaxLength(16, ErrorMessage = "Máximo número de caracteres {1}.")]
        //public string? ConstanciaCUIL { get; set; } 

        //[Required(ErrorMessage = "Campo obligatorio")]
        //[MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        //public string? PartidaNacimiento { get; set; }

        //[Required(ErrorMessage = "Campo obligatorio")]
        //[MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        //public string? Analitico { get; set; }

        //[Required(ErrorMessage = "Campo obligatorio")]
        //[MaxLength(40, ErrorMessage = "Máximo número de caracteres {1}.")]
        //public string? FotoCarnet { get; set; }

        #endregion

        #region Tabla Carrera relacionada
        public int CarreraId { get; set; }
        #endregion


        #region Listas de certificados
        public List<CertificadoAlumno> CertificadosAlumno { get; set; } = new List<CertificadoAlumno>();
        #endregion

        #region Lista de alumnos que cursan la materia
        public List<CursadoMateria> MateriasCursadas { get; set; } = new List<CursadoMateria>();
        #endregion

        #endregion
    }

}

        
