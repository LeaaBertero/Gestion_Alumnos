using Gestion_Alumnos.BD.Data;
using Microsoft.EntityFrameworkCore;
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



        #region Metodo get por doc
        public async Task<Alumno> GetAlumnoPorDocumento(string documento)
        {
            return await context.Alumnos
                .Include(a => a.Usuario)
                .Include(c => c.Carrera)
                .Include(a => a.Usuario.Persona)
                .Include(a => a.Usuario.Persona.TipoDocumento)
                .FirstOrDefaultAsync(a => a.Usuario.Persona.Documento == documento);
        }

        #endregion
    }
}
