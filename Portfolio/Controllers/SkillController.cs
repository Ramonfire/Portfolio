using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("omarZaida/skills")]
    public class SkillController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public SkillController(ApplicationDBContext inContext)
        {
            context = inContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(context.Skills.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(uint id)
        {
            var item = context.Skills
            .Include(s => s.Category)
            .FirstOrDefault(s => s.Id == id);

            if (item == null) return NotFound();
            return Ok(item);
        }
    }
}