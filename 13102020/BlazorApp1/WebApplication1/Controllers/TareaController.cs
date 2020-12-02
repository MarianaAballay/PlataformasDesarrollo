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
        public IActionResult Post(Tarea valor)
        {
            var local = _context.Tarea.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
            if (valor.Id == 0)
            {
                _context.Entry(valor).State = EntityState.Added;
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;

            }
            _context.SaveChanges();
            return Ok(valor);
        }
    }
}
