using Microsoft.AspNetCore.Mvc;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("omarZaida/skillcategories")]
    public class SkillCategoryController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public SkillCategoryController(ApplicationDBContext inContext)
        {
            context = inContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(context.SkillCategories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(uint id)
        {
            var item = context.SkillCategories.Find(id);
            if (item == null) return NotFound();
            return Ok(item);
        }
    }
}