using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Models
{
    public class Developer
    {
        private Developer(Guid id, string name) 
        { 
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public static (Developer Developer, string error) Create(Guid id, string name)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(name))
            {
                error = "Название студии разработчиков не должен быть пустым";
            }

            var develop = new Developer(id, name);

            return (develop, error);
        }
    }
}