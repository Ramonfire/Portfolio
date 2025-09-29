using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Controllers
{
    [ApiController]
    [Route("omarZaida/skills")]
    public class SkillController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        private readonly ISkillRepository repo;
        public SkillController(ApplicationDBContext inContext, ISkillRepository inRepo)
        {
            context = inContext;
            repo = inRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var skills = await repo.GetAllAsynch();

            return Ok(skills);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(uint id)
        {
            var item = repo.GetById(id);

            if (item == null) return NotFound();
            return Ok(item);
        }
    }
}