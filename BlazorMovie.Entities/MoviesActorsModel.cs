namespace BlazorMovie.Entities
{
    public class MoviesActorsModel
    {
        public int PersonID { get; set; }
        public int MovieID { get; set; }
        public PersonModel Person { get; set; }
        public MovieModel Movie { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }
    }
}