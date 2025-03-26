namespace GameDiary.Api.Contracts
{
    public record DevelopResponse(
        Guid id,
        string name);

    public record DevelopRequest(
        string name);
}
