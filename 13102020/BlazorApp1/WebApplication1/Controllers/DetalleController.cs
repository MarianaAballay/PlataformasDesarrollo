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
    public class DetalleController : ControllerBase
    {
        private readonly TareasDbContext _context;
        public DetalleController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Detalle> Get()
        {
            return _context.Detalle.ToList();
        }

        [HttpGet("{id}")]
        public Detalle Get(int id)
        {
            return _context.Detalle.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public IActionResult Post(Detalle valor) {
            var local = _context.Detalle.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
            if(valor.Id ==0){
                _context.Entry(valor).State = EntityState.Added;
            }
            else {
                _context.Entry(valor).State = EntityState.Modified;

            }
            _context.SaveChanges();
            return Ok(valor);
        }

        [HttpDelete("{id}")]
        public Detalle DeleteDetalle(int id)
        {
            Detalle borrardetalle = _context.Detalle.Find(id);
            _context.Detalle.Remove(borrardetalle);
            _context.SaveChanges();
            return borrardetalle;
        }


    }
}
