using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Bll.Services
{
    public class DeveloperService : IDeveloperService
    {
        private readonly IDevelopRepository _developRepository;

        public DeveloperService(IDevelopRepository developRepository)
        {
            _developRepository = developRepository; 
        }

        public async Task<List<Developer>> GetAllDevelopers()
        {
            return await _developRepository.Get();
        }

        public async Task<Guid> AddDeveloper(Developer developer)
        { 
            return await _developRepository.Create(developer);  
        }

        public async Task<Guid> UpdateDeveloper(Guid id, string name)
        { 
            return await _developRepository.Update(id, name);   
        }

        public async Task<Guid> DeleteDeveloper(Guid id)
        { 
            return await _developRepository.Delete(id);
        }
    }
}
