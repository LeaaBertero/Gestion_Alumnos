using Gestion_Alumnos.BD.Data;
using Gestion_Alumnos.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Controllers
{
    [ApiController]
    [Route("api/Materia")]
    public class MateriaControllers : ControllerBase
    {
        private readonly Context context;

        #region constructor
        public MateriaControllers(Context context)
        {
            this.context = context;
        }
        #endregion

        //Método Get
        #region Get
        [HttpGet]
        public async Task<ActionResult<List<Materia>>> Get()
        {
            return await context.Materias.ToListAsync();
        }
        #endregion

        //Método Post
        #region Post
        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearMateriaDTO entidadDTO)
        {
            try
            {
                Materia entidad = new Materia();

                entidad.Nombre = entidadDTO.Nombre;
                entidad.Formato = entidadDTO.Formato;
                entidad.Formacion = entidadDTO.Formacion;
                entidad.ResolucionMinisterial = entidadDTO.ResolucionMinisterial;
                entidad.Anno = entidadDTO.Anno;



                context.Materias.Add(entidad);
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
