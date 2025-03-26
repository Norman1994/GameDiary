using GameDiary.Api.Contracts;
using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameDiary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        { 
            _publisherService = publisherService;   
        }

        [HttpGet]
        public async Task<ActionResult<List<PublisherResponse>>> GetPublishers()
        { 
            var publishers = await _publisherService.GetAllPublishers();

            var responce = publishers.Select(b => new PublisherResponse(b.Id, b.Name));

            return Ok(responce);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreatePublisher([FromBody] PublisherRequest request)
        {
            var (publisher, error) = Publisher.Create(
                Guid.NewGuid(),
                request.name);

            if (!string.IsNullOrEmpty(error))
            {
                return BadRequest(error);
            }

            var publisherId = await _publisherService.AddPublisher(publisher);

            return Ok(publisherId);
        }
    }
}
