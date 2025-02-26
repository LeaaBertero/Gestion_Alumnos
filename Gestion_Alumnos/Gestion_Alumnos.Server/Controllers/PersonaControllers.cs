using AutoMapper;
using Gestion_Alumnos.Server.Repositorio;
using Gestion_Alumnos.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Controllers
{
    [ApiController]
    [Route("api/Persona")]
    public class PersonaControllers : ControllerBase
    {
        private readonly IPersonaRepositorio eRepositorio;
        private readonly IMapper mapper;

        public PersonaControllers(IPersonaRepositorio eRepositorio, IMapper mapper)
        {
            this.eRepositorio = eRepositorio;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<Persona>>> Get()
        {
            return await eRepositorio.Select();
        }




        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearPersonaDTO entidadDTO)
        {
            try
            {
                Persona entidad = mapper.Map<Persona>(entidadDTO);

                var personaInsertada = await eRepositorio.Insert(entidad);

                return Ok(personaInsertada);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
