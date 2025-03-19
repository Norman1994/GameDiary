using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Abstractions
{
    public interface IDeveloperService
    {
        Task<List<Developer>> GetAllDevelopers();

        Task<Guid> AddDeveloper(Developer developer);

        Task<Guid> UpdateDeveloper(Guid id, string name);

        Task<Guid> DeleteDeveloper(Guid id);
    }
}
