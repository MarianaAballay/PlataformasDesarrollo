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
    public class RecursoController : ControllerBase
    {
        private readonly TareasDbContext _context;
        public RecursoController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Recurso> Get()
        {
            //return _context.Recurso.ToList();
            return _context.Recurso.Include(i => i.Usuario).ToList();
        }


        [HttpGet("{id}")]
        public Recurso Get(int id)
        {
            return _context.Recurso.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public Recurso Post(Recurso valor)
        {
            if (valor.Id == 0)
            {
                _context.Recurso.Add(valor);
            }
            else
            {
                _context.Recurso.Attach(valor);
                _context.Recurso.Update(valor);

            }
            _context.SaveChanges();
            return valor;
        }
    }
}
