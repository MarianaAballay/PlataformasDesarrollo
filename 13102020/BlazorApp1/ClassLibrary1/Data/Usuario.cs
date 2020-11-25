using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1.Data
{
    public class Usuario
    {

        public Usuario() { }

        public Usuario(int Id, String nombre, String clave)
        {
            this.Id = Id;
            this.nombre = nombre;
            this.clave = clave;

        }

        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        public String nombre { get; set; }
        [Required]
        public String clave { get; set; }

    }
}
