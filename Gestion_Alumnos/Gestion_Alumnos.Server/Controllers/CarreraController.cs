using Gestion_Alumnos.Server.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Controllers
{
    [ApiController]
    [Route("api/Carrera")]
    public class CarreraController
    {
        private readonly ICarreraRepositorio repositorio;

        public CarreraController(ICarreraRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Carrera>>> Get() 
        {
            return await repositorio.Select();
        }
    }
}
