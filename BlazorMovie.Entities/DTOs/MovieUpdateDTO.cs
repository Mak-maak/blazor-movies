using System.Collections.Generic;

namespace BlazorMovie.Entities.DTOs
{
    public class MovieUpdateDTO
    {
        public MovieModel Movie { get; set; }
        public List<PersonModel> Actors { get; set; }
        public List<GenreModel> SelectedGenres { get; set; }
        public List<GenreModel> NotSelectedGenres { get; set; }
    }
}