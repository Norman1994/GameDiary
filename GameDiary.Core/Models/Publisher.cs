using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Models
{
    public class Publisher
    {
        private Publisher(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public static (Publisher Publisher, string error) Create(Guid id, string name)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(name))
            {
                error = "Название студии издателей не должен быть пустым";
            }

            var publisher = new Publisher(id, name);

            return (publisher, error);
        }
    }
}