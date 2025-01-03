using Gestion_Alumnos.BD.Data;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Repositorio
{
    public class MateriaRepositorio : Repositorio<Materia>, IMateriaRepositorio
    {
        private readonly Context context;

        public MateriaRepositorio(Context context) : base(context)
        {
            this.context = context;
        }
    }
}
