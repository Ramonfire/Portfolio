using Microsoft.AspNetCore.Mvc;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("omarZaida/educations")]
    public class EducationController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public EducationController(ApplicationDBContext inContext)
        {
            context = inContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(context.Educations.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(uint id)
        {
            var item = context.Educations.Find(id);
            if (item == null) return NotFound();
            return Ok(item);
        }
    }
}