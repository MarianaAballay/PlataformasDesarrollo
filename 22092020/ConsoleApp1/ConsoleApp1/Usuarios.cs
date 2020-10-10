using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1
{
    
    class Usuarios
    {
       
        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        public String nombre { get; set; }
        [Required]
        public String clave { get; set; }

        
        
    }
}
