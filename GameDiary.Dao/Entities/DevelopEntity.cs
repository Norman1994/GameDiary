﻿using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Dao.Entities
{
    public class DevelopEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public List<GameDeveloperEntity> GameDeveloper  { get; init; } = new();
    }
}
