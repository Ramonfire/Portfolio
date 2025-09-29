using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Controllers
{
    [ApiController]
    [Route("omarZaida")]
    public class ProfileController: ControllerBase
    {
        private readonly ApplicationDBContext context;
        private readonly IProfileRepository repo;
        public ProfileController(ApplicationDBContext inContext, IProfileRepository inRepo)
        {
            context = inContext;
            repo = inRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProfiles()
        {
            var profile = await repo.GetAllAsynch();
            return Ok(profile);
        }

        [HttpGet ("{id}")]
        public IActionResult GetProfile([FromRoute]uint id) 
        {
            var profile = repo.GetById(id);
            if (profile == null) 
            {
                return NotFound();
            }
            return Ok(profile);
        }
    }
}
