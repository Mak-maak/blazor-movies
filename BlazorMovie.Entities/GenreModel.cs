using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovie.Entities
{
    public class GenreModel
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public List<MovieGenresModel> MoviesGenres { get; set; }
    }
}