using Gestion_Alumnos.BD.Data;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Repositorio
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        private readonly Context context;

        public UsuarioRepositorio(Context context) : base(context)
        {
            this.context = context;
        }
    }
}
