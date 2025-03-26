using GameDiary.Api.Contracts;
using GameDiary.Core.Abstractions;
using Microsoft.AspNetCore.Mvc;
using GameDiary.Core.Models;

namespace GameDiary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateDeveloper([FromBody] DevelopRequest request)
        {
            var (develop, error) = Developer.Create(
                Guid.NewGuid(),
                request.name);

            if (!string.IsNullOrEmpty(error))
            {
                return BadRequest(error);
            }

            var developId = await _developerService.AddDeveloper(develop);

            return Ok(developId);
        }

        [HttpPut("{id:Guid}")]
        public async Task<ActionResult<Guid>> UpdateDeveloper(Guid id, [FromBody] DevelopRequest request)
        {
            var developId = await _developerService.UpdateDeveloper(id, request.name);

            return Ok(developId);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<Guid>> DeleteDeveloper(Guid id)
        { 
            var developId = await _developerService.DeleteDeveloper(id);

            return Ok(developId);
        }
    }
}
