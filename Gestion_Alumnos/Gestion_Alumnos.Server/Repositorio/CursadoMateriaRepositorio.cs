using Microsoft.EntityFrameworkCore;
using Gestion_Alumnos.BD.Data;
using Gestion_Alumnos.Shared.DTO;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Repositorio
{
    public class CursadoMateriaRepositorio : Repositorio<CursadoMateria>, ICursadoMateriaRepositorio
    {
        private readonly Context context;

        public CursadoMateriaRepositorio(Context context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<GetMateriaCursadaDTO>> GetMateriasCursadasByDocumentoAsync(string documento)
        {
            var materiasCursadas = await context.CursadoMaterias
                .Include(mc => mc.Turno.MateriaEnPlanEstudio.Materia)
                .Include(mc => mc.Notas)
                .Where(mc => mc.Alumno.Usuario.Persona.Documento == documento)
                .Select(mc => new GetMateriaCursadaDTO
                {
                    Id = mc.Id,
                    MateriaNombre = mc.Turno.MateriaEnPlanEstudio.Materia.Nombre,
                    Turno = mc.Turno.Horario,
                    CondicionActual = mc.CondicionActual,
                    Notas = mc.Notas.Select(n => new GetNotaDTO
                    {
                        Id = n.Id,
                        TipoEvaluacion = n.Evaluacion.TipoEvaluacion,
                        ValorNota = n.ValorNota
                    }).ToList()
                }).ToListAsync();

            return materiasCursadas;
        }
    }
}
