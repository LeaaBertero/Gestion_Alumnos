using Gestion_Alumnos.BD.Data;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Repositorio
{
    public class CarreraRepositorio : Repositorio<Carrera> , ICarreraRepositorio
    {
        private readonly Context context;

        public CarreraRepositorio(Context context) : base(context)
        {
            this.context = context;
        }
    }
}
