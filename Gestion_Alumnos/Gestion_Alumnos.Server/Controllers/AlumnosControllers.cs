using Gestion_Alumnos.BD.Data;
using Gestion_Alumnos.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Controllers
{
    [ApiController]
    [Route("api/Alumnos")]
    public class AlumnosControllers : ControllerBase
    {
        private readonly Context context;

        //constructor
        #region constructor
        public AlumnosControllers(Context context)
        {
            this.context = context;
        }
        #endregion

        //Método Get
        #region Get
        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> Get() 
        {
            return await context.Alumnos.ToListAsync();
        }
        #endregion

        //Método Post
        #region Post
        [HttpPost]
        public async Task<ActionResult<int>>Post(CrearAlumnoDTO entidadDTO) 
        {
            try
            {
                Alumno entidad = new Alumno();
                
                entidad.Nombre = entidadDTO.Nombre;
                entidad.Sexo = entidadDTO.Sexo;
                entidad.FechaNacimiento = entidadDTO.FechaNacimiento;
                entidad.Edad = entidadDTO.Edad;
                entidad.CUIL = entidadDTO.CUIL;
                entidad.Pais = entidadDTO.Pais;
                entidad.Provincia = entidadDTO.Provincia;
                entidad.TituloBase = entidadDTO.TituloBase;
                entidad.CUS = entidadDTO.CUS;
                entidad.Estado = entidadDTO.Estado;

                
                context.Alumnos.Add(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
        }
        #endregion

        
    }
}
