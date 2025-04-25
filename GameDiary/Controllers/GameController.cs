using GameDiary.Api.Contracts;
using GameDiary.Bll.Services;
using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using GameDiary.Dao.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GameDiary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;
        private readonly IGameDeveloperService _gameDeveloperService;
        private readonly IGamePublisherRepository _gamePublisherRepository;

        public GameController(IGameService gameService, IGameDeveloperService gameDeveloperService, IGamePublisherRepository gamePublisherRepository)
        {
            _gameService = gameService;
            _gameDeveloperService = gameDeveloperService;
            _gamePublisherRepository = gamePublisherRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<GameResponse>>> GetGames()
        {
            var games = await _gameService.GetAllGames();

            var responce = games.Select(b => new GameResponse(
                b.Id,
                b.Name,
                b.IsLoving,
                b.Status,
                b.Rating,
                b.GameDevelopers.Select(x => x.DeveloperEntity.Name).ToList(),
                b.GamePublishers.Select(y => y.PublisherEntity.Name).ToList())).ToList();

            return Ok(responce);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateGame([FromBody] GameAddResponse gameResponse)
        {
            Guid newGameId = Guid.NewGuid();

            var (game, error) = Game.Create(
                newGameId,
                gameResponse.Name,
                gameResponse.Rating,
                gameResponse.status,
                gameResponse.IsLoving);

            var gameId = await _gameService.AddGame(game);

            foreach (var gamePub in gameResponse.Publishers)
            {
                var (gamePublisher, publisherError) = GamePublisher.Create(
                    newGameId,
                    gamePub
                );

                await _gamePublisherRepository.AddGamePublisher(gamePublisher);
            }

            foreach (var gameDev in gameResponse.Developers) 
            {
                var (gameDeveloper, gameError) = GameDeveloper.Create(
                    newGameId,
                    gameDev
                );

                await _gameDeveloperService.AddGameDeveloper(gameDeveloper);
            }

            if (!string.IsNullOrEmpty(error))
            {
                return BadRequest(error);
            }

            return Ok(gameId);
        }
    }
}
