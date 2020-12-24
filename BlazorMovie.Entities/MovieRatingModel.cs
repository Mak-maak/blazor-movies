using System;

namespace BlazorMovie.Entities
{
    public class MovieRatingModel
    {
        public int ID { get; set; }
        public int Rate { get; set; }
        public DateTime RatingDate { get; set; }
        public int MovieID { get; set; }
        public MovieModel Movie { get; set; }
        public string UserID { get; set; }
    }
}