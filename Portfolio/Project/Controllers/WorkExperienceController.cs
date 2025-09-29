using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Controllers
{
    [ApiController]
    [Route("omarZaida/workexperiences")]
    public class WorkExperienceController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        private readonly IWorkExperienceRepository repo;
        public WorkExperienceController(ApplicationDBContext inContext,IWorkExperienceRepository inRepo)
        {
            context = inContext;
            repo = inRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var WorkExp =await repo.GetAllAsynch();
            return Ok(WorkExp);
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