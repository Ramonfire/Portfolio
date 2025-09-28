using Microsoft.AspNetCore.Mvc;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("omarZaida/masteredlanguages")]
    public class MasteredLanguageController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public MasteredLanguageController(ApplicationDBContext inContext)
        {
            context = inContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(context.MasteredLanguages.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(uint id)
        {
            var item = context.MasteredLanguages.Find(id);
            if (item == null) return NotFound();
            return Ok(item);
        }
    }
}