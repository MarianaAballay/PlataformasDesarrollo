using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.Data;
using WebApplication1.Data;

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
        public Usuario Post(Usuario valor)
        {
            if (valor.Id == 0)
            {
                _context.Usuario.Add(valor);
            }
            else
            {
                _context.Usuario.Attach(valor);
                _context.Usuario.Update(valor);

            }
            _context.SaveChanges();
            return valor;
        }
    }
}
