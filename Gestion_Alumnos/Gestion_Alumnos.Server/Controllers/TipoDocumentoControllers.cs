using AutoMapper;
using Gestion_Alumnos.BD.Data;
using Gestion_Alumnos.Server.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Controllers
{
    [ApiController]
    [Route("api/TipoDocumento")]
    public class TipoDocumentoControllers : ControllerBase
    {
        private readonly ITipoDocumentoRepositorio eRepositorio;
        private readonly IMapper mapper;

        public TipoDocumentoControllers(ITipoDocumentoRepositorio eRepositorio, IMapper mapper)
        {
            this.eRepositorio = eRepositorio;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<TipoDocumento>>> Get()
        {
            return await eRepositorio.Select();
        }

    }
}
