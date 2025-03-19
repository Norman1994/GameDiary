using GameDiary.Api.Contracts;
using GameDiary.Core.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace GameDiary.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevelopController : ControllerBase
    {
        private readonly IDeveloperService _developerService;

        public DevelopController(IDeveloperService developerService)
        {
            _developerService = developerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<DevelopResponse>>> GetDevelopers()
        {
            var developers = await _developerService.GetAllDevelopers();

            var responce = developers.Select(b => new DevelopResponse(b.Id, b.Name));

            return Ok(responce);    
        }
    }
}
