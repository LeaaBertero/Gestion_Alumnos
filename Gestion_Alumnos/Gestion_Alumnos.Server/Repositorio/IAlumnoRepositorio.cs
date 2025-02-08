using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Repositorio
{
    #region Interfáz Alumno
    public interface IAlumnoRepositorio : IRepositorio<Alumno>
    {
        Task<Alumno> GetAlumnoPorDocumento(string documento);
    }
    #endregion
}
