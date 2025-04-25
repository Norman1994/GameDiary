using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Models
{
    public class Game 
    {
        public Game() { }

        public Game(Guid id, string name, decimal rating, GameStatus status, bool isLoving) 
        { 
            Id = id;
            Name = name;    
            Rating = rating;   
            Status = status;   
            IsLoving = isLoving;
        }

        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Rating { get; set; }

        public GameStatus Status { get; set; }

        public bool IsLoving { get; set; }

        public List<GameDeveloper> GameDevelopers { get; set; } = new();

        public List<GamePublisher> GamePublishers { get; set; } = new();

        public static (Game game, string error) Create(Guid id, string name, decimal rating, GameStatus status, bool isLoving)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(name))
            {
                error = "Название игры не должен быть пустым";
            }

            var game = new Game(id, name, rating, status, isLoving);

            return (game, error);
        }
    }

    public enum GameStatus
    { 
        NotStarted,
        Completed,
        InProccess,
        NotCompleted
    }
}
