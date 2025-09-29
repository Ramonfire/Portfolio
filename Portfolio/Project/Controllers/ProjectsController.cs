using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Controllers
{
    [ApiController]
    [Route("omarZaida/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        private readonly IProjectsRepository repo;
        public ProjectsController(ApplicationDBContext inContext, IProjectsRepository inRepo)
        {
            context = inContext;
            repo = inRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await repo.GetAllAsynch());
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