﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    class Tareas
    {

        public Tareas() { }
       /* public Tareas(string titulo, string vencimiento, int estimacion, Recursos responsable, Boolean estado)
        {
            this.titulo = titulo;
            this.vencimiento = vencimiento;
            this.estimacion = estimacion;
            this.responsable = responsable;
            this.estado = estado;
        }*/

        public int Id { get; set; }
        [Required(ErrorMessage = "Título es requerido")]
        public String titulo { get; set; }
        public String vencimiento { get; set; }
        public int estimacion { get; set; }
        public Recursos responsable { get; set; }
        public Boolean estado { get; set; }
        public TipoTarea tipo { get; set; }

        
    }
}
