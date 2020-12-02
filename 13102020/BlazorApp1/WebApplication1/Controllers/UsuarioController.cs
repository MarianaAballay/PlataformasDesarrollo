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
    public class UsuarioController : ControllerBase
    {
        private readonly TareasDbContext _context;
        public UsuarioController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            return _context.Usuario.ToList();
        }


        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return _context.Usuario.Where(i => i.Id == id).Single();
        }


        [HttpPost]
        public IActionResult Post(Usuario valor)
        {
            var local = _context.Usuario.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));
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
