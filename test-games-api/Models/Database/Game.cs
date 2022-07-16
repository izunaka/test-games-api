using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test_games_api.Models.Database
{
    public class Game
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string? StudioName { get; set; }

        public List<Genre> Genres { get; set; }
    }
}
