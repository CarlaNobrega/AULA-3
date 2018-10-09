using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fp_stack.core.Models;
using fp_stack.core.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;

namespace fp_stack_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerguntasController : Controller
    {

        private Context _context;

        public PerguntasController(Context context)
        {
            _context = context;
        }

        //public List<Pergunta> Index()
        //{
        //    return _context.Perguntas.ToList();
        //}

        //[HttpGet]
        //[Route("")]
        public ActionResult<List<Pergunta>> Get()
        {
            var times = _context.Perguntas.ToList();
            //if (times.Count == 0)
            //    return NotFound();

            return _context.Perguntas.ToList();
        }

        //[HttpGet]
        //[Route("{id}")]
        //public ActionResult<Pergunta> Get(int id)
        //{
        //    var pergunta = _context.Perguntas.FirstOrDefault(t => t.Id == id);
        //    if (pergunta == null)
        //        return NotFound();

        //    return Ok(pergunta);
        //}

        [HttpPost]
        public ActionResult<Pergunta> Post(Pergunta pergunta)
        {
            if (ModelState.IsValid)
            {
                _context.Perguntas.Add(pergunta);
                _context.SaveChanges();
                return Created($"/api/perguntas/{pergunta.Id}", pergunta);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<Pergunta> Put(int id, [FromBody]Pergunta pergunta)
        {
            if (ModelState.IsValid)
            {
                _context.Attach(pergunta);
                _context.Entry(pergunta).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok(pergunta);
            }
            return BadRequest(ModelState);
        }

        //[HttpDelete]
        //[Route("{id}")]
        //public ActionResult Delete(int id)
        //{
        //    var pergunta = _context.Perguntas.FirstOrDefault(t => t.Id == id);
        //    if (pergunta == null)
        //        return NotFound();

        //    _context.Perguntas.Remove(pergunta);
        //    _context.SaveChanges();

        //    return NoContent();
        //}
    }
}