using Gestion_Alumnos.BD.Data;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Repositorio
{
    public class AlumnoRepositorio : Repositorio<Alumno>, IAlumnoRepositorio
    {
        #region creacion y asignacion de campo context
        private readonly Context context;

        public AlumnoRepositorio(Context context) : base(context)
        {
            this.context = context;
        }
        #endregion
    }
}
