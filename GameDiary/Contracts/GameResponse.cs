using GameDiary.Core.Models;

namespace GameDiary.Api.Contracts
{
    public record GameResponse(
        Guid Id,
        string Name,
        bool IsLoving,
        GameStatus status,
        decimal Rating,
        List<string> GameDevelopers,
        List<string> GamePublishers
    );

    public record GameAddResponse(
        Guid Id,
        string Name,
        bool IsLoving,
        GameStatus status,
        decimal Rating,
        List<Guid> Developers,
        List<Guid> Publishers
    );
}
