using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Tarea
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int responsableId { get; set; }
        public Recurso Responsable { get; set; }
        public Boolean Estado { get; set; }
        public int tipoTareaId { get; set; }
        public TipoTarea tipo { get; set; }
    }
}
