using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Dao.Entities
{
    public class PublisherEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
