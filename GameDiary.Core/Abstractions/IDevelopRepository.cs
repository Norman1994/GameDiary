using GameDiary.Core.Models;

namespace GameDiary.Core.Abstractions
{
    public interface IDevelopRepository
    {
        Task<List<Developer>> Get();

        Task<Guid> Create(Developer developer);

        Task<Guid> Update(Guid id, string name);

        Task<Guid> Delete(Guid id);
    }
}