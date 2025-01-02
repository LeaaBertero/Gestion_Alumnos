using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Alumnos.Shared.DTO
{
    public class CrearAlumnoDTO
    {
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
    }
}
