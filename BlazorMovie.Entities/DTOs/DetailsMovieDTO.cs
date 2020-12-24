using System.Collections.Generic;

namespace BlazorMovie.Entities.DTOs
{
    public class DetailsMovieDTO
    {
        public MovieModel Movie { get; set; }
        public List<GenreModel> Genres { get; set; }
        public List<PersonModel> Actors { get; set; }
        public double AverageVote { get; set; }
        public int UserVote { get; set; }
    }
}