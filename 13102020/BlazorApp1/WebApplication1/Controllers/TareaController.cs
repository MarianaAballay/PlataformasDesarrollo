using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.Data;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly TareasDbContext _context;
        public TareaController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Tarea> Get()
        {
            //return _context.Tarea.ToList();
            return _context.Tarea.Include(i => i.Responsable).ToList();
        }


        [HttpGet("{id}")]
        public Tarea Get(int id)
        {
            return _context.Tarea.Where(i => i.Id == id).Single();
        }


        [HttpPost]
        public Tarea Post(Tarea valor)
        {
            if (valor.Id == 0)
            {
                _context.Tarea.Add(valor);
            }
            else
            {
                _context.Tarea.Attach(valor);
                _context.Tarea.Update(valor);

            }
            _context.SaveChanges();
            return valor;
        }
    }
}
