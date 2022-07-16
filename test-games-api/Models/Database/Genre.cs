using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test_games_api.Models.Database
{
    public class Genre
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Game> Games { get; set; }
    }
}
