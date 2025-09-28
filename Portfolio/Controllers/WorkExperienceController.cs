using Microsoft.AspNetCore.Mvc;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("omarZaida/workexperiences")]
    public class WorkExperienceController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public WorkExperienceController(ApplicationDBContext inContext)
        {
            context = inContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(context.WorkExperiences.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(uint id)
        {
            var item = context.WorkExperiences.Find(id);
            if (item == null) return NotFound();
            return Ok(item);
        }
    }
}