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

        //Método Put
        #region Put
        //[HttpPut("{id:int}")]
        //public async Task<ActionResult> Put(int id, [FromBody] Alumno entidad) 
        //{
        //    if (id != entidad.Id)
        //    {
        //        return BadRequest("Datos incorrectos");
        //    }

        //    var Dammy = await context.Alumnos.Where(e => e.Id == id).FirstOrDefaultAsync();

        //    if (Dammy == null) 
        //    {
        //        return NotFound("No existe el alumno buscado.");    
        //    }
            
        //    Dammy.Nombre = entidad.Nombre;
        //    Dammy.Sexo = entidad.Sexo;
        //    Dammy.FechaNacimiento = entidad.FechaNacimiento;
        //    Dammy.Edad = entidad.Edad;
        //    Dammy.CUIL = entidad.CUIL;
        //    Dammy.Pais = entidad.Pais;
        //    Dammy.Provincia = entidad.Provincia;
        //    Dammy.TituloBase = entidad.TituloBase;
        //    Dammy.CUS = entidad.CUS;
        //    Dammy.Estado = entidad.Estado;

        //    try
        //    {
        //        context.Alumnos.Update(Dammy);
        //        await context.SaveChangesAsync();
        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest(e.Message);   
        //        //throw;
        //    }

        //    return Ok();
        //}
        #endregion
    }
}
