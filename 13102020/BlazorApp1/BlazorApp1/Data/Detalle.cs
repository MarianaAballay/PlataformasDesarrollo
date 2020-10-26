using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Detalle
    {
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public String tiempo { get; set; }
        public int tareaId { get; set; }
        public Tarea tarea { get; set; }
        public int recursoId { get; set; }
        public Recurso recurso { get; set; }
    }
}
