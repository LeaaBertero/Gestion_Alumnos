using Gestion_Alumnos.BD.Data;
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
        public async Task<ActionResult<int>>Post(Alumno entidad) 
        {
            try
            {
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
