using Gestion_Alumnos.BD.Data;

namespace Gestion_Alumnos.Server.Repositorio
{
    public interface IRepositorio<E> where E : class, IEntityBase
    {
        Task<int> Insert(E entidad);
        Task<List<E>> Select();
    }
}