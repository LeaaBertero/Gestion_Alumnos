using AutoMapper;
using Gestion_Alumnos.Server.Repositorio;
using Gestion_Alumnos.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuarioControllers : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUsuarioRepositorio repositorio;

        public UsuarioControllers(IMapper mapper, IUsuarioRepositorio repositorio)
        {
            this.mapper = mapper;
            this.repositorio = repositorio;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearUsuarioDTO entidadDTO)
        {
            try
            {
                Usuario entidad = mapper.Map<Usuario>(entidadDTO);

                return await repositorio.Insert(entidad);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
