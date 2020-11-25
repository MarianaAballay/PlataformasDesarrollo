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
        public Detalle Post(Detalle valor) {
            if (valor.Id == 0)
            {
                _context.Detalle.Add(valor);
            }
            else {
                _context.Detalle.Attach(valor);
                _context.Detalle.Update(valor);

            }
            _context.SaveChanges();
            return valor;
        }


    }
}
