using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1
{
   
    class Detalles
    {
        public int Id { get; set; }
        [Required]
        public String fecha { get; set; }
        public String tiempo { get; set; }
        public Tareas tareas { get; set; }
        public Recursos recurso { get; set; }
       

    }
}
