using Gestion_Alumnos.Server.Repositorio;
using Gestion_Alumnos.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_Alumnos.Server.Controllers
{
    [ApiController]
    [Route("api/CursadoMateria")]
    public class CursadoMateriaControllers : ControllerBase
    {
        private readonly ICursadoMateriaRepositorio repositorio;

        public CursadoMateriaControllers(ICursadoMateriaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        [HttpGet("{documento}")]
        public async Task<ActionResult<List<GetMateriaCursadaDTO>>> GetMateriasCursadasPorDocumento(string documento)
        {
            var materiasCursadas = await repositorio.GetMateriasCursadasByDocumentoAsync(documento);

            if (materiasCursadas == null || !materiasCursadas.Any())
            {
                return NotFound($"No se encontraron materias cursadas para el documento {documento}");
            }

            return Ok(materiasCursadas);
        }
    }
}
