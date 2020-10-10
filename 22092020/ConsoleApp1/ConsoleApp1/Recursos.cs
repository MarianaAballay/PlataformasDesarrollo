using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    class Recursos
    {
        public int Id { get; set; }
        [StringLength(45, MinimumLength = 2,
        ErrorMessage = "El nombre debe tener un máximo de 45 caracteres y un mínimo de 2")]
        public String nombre { get; set; }
        public Usuarios usuario { get; set; }

    }
}
