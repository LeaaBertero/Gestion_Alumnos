using Gestion_Alumnos.Shared.DTO;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Repositorio
{
    public interface ICursadoMateriaRepositorio : IRepositorio<CursadoMateria>
    {
        Task<List<GetMateriaCursadaDTO>> GetMateriasCursadasByDocumentoAsync(string documento);
    }
}