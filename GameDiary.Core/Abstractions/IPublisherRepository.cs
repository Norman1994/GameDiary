using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Abstractions
{
    public interface IPublisherRepository
    {
        Task<List<Publisher>> Get();

        Task<Guid> Create(Publisher publisher);

        Task<Guid> Update(Guid id, string name);

        Task<Guid> Delete(Guid id);
    }
}
