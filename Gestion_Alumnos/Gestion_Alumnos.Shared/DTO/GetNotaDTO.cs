using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Alumnos.Shared.DTO
{
    public class GetNotaDTO
    {
        public int Id { get; set; }
        public string TipoEvaluacion { get; set; }
        public int ValorNota { get; set; }
    }
}
