using Gestion_Alumnos.BD.Data;
using Microsoft.Identity.Client;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Repositorio
{
    public class TipoDocumentoRepositorio : Repositorio<TipoDocumento> , ITipoDocumentoRepositorio
    {
        private readonly Context context;

        public TipoDocumentoRepositorio(Context context) : base(context)
        {
            this.context = context;
        }
    }
}
