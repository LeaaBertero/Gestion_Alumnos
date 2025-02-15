using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Alumnos.Shared.DTO
{
    public class GetMateriaCursadaDTO
    {
        public int Id { get; set; }
        public string MateriaNombre { get; set; }
        public string Turno { get; set; }
        public string CondicionActual { get; set; }
        public List<GetNotaDTO> Notas { get; set; }
    }
}
