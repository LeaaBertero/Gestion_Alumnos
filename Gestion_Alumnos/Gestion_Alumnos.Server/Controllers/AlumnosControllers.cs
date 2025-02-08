using AutoMapper;
using Gestion_Alumnos.BD.Data;
using Gestion_Alumnos.Server.Repositorio;
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
        private readonly IAlumnoRepositorio repositorio;
        private readonly IMapper mapper;

        //constructor
        #region constructor
        public AlumnosControllers(IAlumnoRepositorio repositorio, IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }
        #endregion

        //Método Get
        #region Get
        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> Get() 
        {
            return await repositorio.Select();
        }
        #endregion

        //Método Post
        #region Post
        [HttpPost]
        public async Task<ActionResult<int>>Post(CrearAlumnoDTO entidadDTO) 
        {
            try
            {             
                Alumno entidad = mapper.Map<Alumno>(entidadDTO);
                                             
                return await repositorio.Insert(entidad);
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
        }
        #endregion


        //Método GetByDoc
        #region GET POR DOCUMENTO
        [HttpGet("Documento/{documento}")]
        public async Task<ActionResult<Alumno>> GetAlumnoPorDocumento(string documento)
        {
            var PersonaAl = await repositorio.GetAlumnoPorDocumento(documento);

            if (PersonaAl == null)
            {
                return NotFound($"No existe un alumno con el documento {documento}");
            }

            var pepe = mapper.Map<Alumno>(PersonaAl);
            return Ok(pepe);
        }
        #endregion

    }
}
        
