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
    [Route("api/Materia")]
    public class MateriaControllers : ControllerBase
    {
       
        private readonly IMateriaRepositorio repositorio;
        private readonly IMapper mapper;

        #region constructor
        public MateriaControllers(IMateriaRepositorio repositorio)//, IMapper mapper )
        {
           
            this.repositorio = repositorio;
            //this.mapper = mapper;
        }
        #endregion

        //Método Get
        #region Get
        [HttpGet]
        public async Task<ActionResult<List<Materia>>> Get()
        {
            return await repositorio.Select(); ;
        }
        #endregion

        //Método Post
        #region Post
        [HttpPost]
        public async Task<ActionResult<int>> Post(Materia entidad)
        {
            try
            {
                return await repositorio.Insert(entidad);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
        #endregion
    }
}


                



        
