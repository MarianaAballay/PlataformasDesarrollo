﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1.Data
{
    public class Tarea
    {
        public Tarea() { }

        public Tarea(int Id, String Titulo, String Vencimiento, String Estimacion, int responsableId, Recurso Responsable, Boolean Estado)
        {
            this.Id = Id;
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;
            this.responsableId = responsableId;
            this.Responsable = Responsable;
            this.Estado = Estado;
        }
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Vencimiento { get; set; }
        public String Estimacion { get; set; }
        public int responsableId { get; set; }
        public Recurso Responsable { get; set; }
        public Boolean Estado { get; set; }
    }
}
