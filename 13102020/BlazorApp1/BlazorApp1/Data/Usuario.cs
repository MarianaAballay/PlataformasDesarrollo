using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data
{
    public class Usuario
    {

        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        public String nombre { get; set; }
        [Required]
        public String clave { get; set; }

    }
}
