using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;
using Potfolio.Project.Models;

namespace Portfolio.Project.Controllers
{
    [ApiController]
    [Route("omarZaida/masteredlanguages")]
    public class MasteredLanguageController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        private readonly IMasteredLanguageRepository repo;
        public MasteredLanguageController(ApplicationDBContext inContext, IMasteredLanguageRepository inRepo)
        {
            context = inContext;
            repo = inRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await repo.GetAllAsynch());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(uint id)
        {
            var item = repo.GetById(id);
            if (item == null) return NotFound();
            return Ok(item);
        }
    }
}