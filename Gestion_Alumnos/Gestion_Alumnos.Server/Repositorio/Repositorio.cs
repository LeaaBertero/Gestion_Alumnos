using AutoMapper;
using Gestion_Alumnos.BD.Data;
using Gestion_Alumnos.Shared.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Repositorio
{
    //clase especializada en hacer un CRUD
    //sobre uma tabla cualquiera de la base de datos
    #region Repositorio
    public class Repositorio<E> : IRepositorio<E> where E : class, IEntityBase
    {
        private readonly Context context;

        #region constructor
        public Repositorio(Context context)
        {
            this.context = context;
        }
        #endregion

        //Select Repositorio
        #region Select Repositorio
        public async Task<List<E>> Select()
        {
            return await context.Set<E>().ToListAsync();
        }
        #endregion

        //Insert Repositorio
        #region Insert Repositorio
        public async Task<int> Insert(E entidad)
        {
            try
            {
                await context.Set<E>().AddAsync(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
            catch (Exception err)
            {

                throw err;
            }
        }
        #endregion

        //Update Repositorio
        //#region Update Repositorio
        //public async Task<bool> Update(int id, E entidad) 
        //{
        //    if (id != entidad.Id) 
        //    {
        //        return false;
        //    }
        //    var Dummy = await SelectById(id);

        //    if (Dummy == null) 
        //    {
        //        return false;
        //    }

        //    try
        //    {
        //        context.Set<E>().Update(entidad);
        //        await context.SaveChangesAsync();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }

        //}
        //#endregion

        //SelectById
        //#region SelectById
        //public async Task<E> SelectById(int id) 
        //{
        //    E? Dummy = await context.Set<E>().AsNoTracking().
        //        FirstOrDefaultAsync(x => x.Id == id);

        //    return Dummy;
        //}
        //#endregion

        //Delete Repositorio
        //#region Delete Repositorio
        //public async Task<bool> Delete(int id) 
        //{
        //    var Dummy = await SelectById(id);

        //    if (Dummy == null) 
        //    {
        //        return false;
        //    }

        //    //return false;

        //    Context.Set<E>().Remove(Dummy);
        //    await context.SaveChangesAsync();
        //    return Ok();
        //}
        //#endregion
    }
    #endregion
}
