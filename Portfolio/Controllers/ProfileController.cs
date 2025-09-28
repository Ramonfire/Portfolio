using Microsoft.AspNetCore.Mvc;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("omarZaida")]
    public class ProfileController: ControllerBase
    {
        private readonly ApplicationDBContext context;
        public ProfileController(ApplicationDBContext inContext)
        {
            context = inContext;
        }
        [HttpGet]
        public IActionResult GetAllProfiles()
        {
            var profile = context.Profiles.ToList();
            return Ok(profile);
        }

        [HttpGet ("{id}")]
        public IActionResult GetProfile([FromRoute]uint id) 
        {
            var profile = context.Profiles.Find(id);
            if (profile == null) 
            {
                return NotFound();
            }
            return Ok(profile);
        }
    }
}
