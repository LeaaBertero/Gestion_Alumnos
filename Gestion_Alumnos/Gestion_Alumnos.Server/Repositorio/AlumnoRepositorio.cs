using Gestion_Alumnos.BD.Data;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Repositorio
{
    public class AlumnoRepositorio : Repositorio<Alumno>, IAlumnoRepositorio
    {
        public AlumnoRepositorio(Context context) : base(context)
        {

        }
    }
}
