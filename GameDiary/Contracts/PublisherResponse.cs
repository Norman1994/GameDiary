namespace GameDiary.Api.Contracts
{
    public record PublisherResponse(
        Guid id,
        string name);

    public record PublisherRequest(
        string name);
}
