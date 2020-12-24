using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovie.Entities
{
    public class MovieModel
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        public bool InTheaters { get; set; }
        public string Trailer { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }
        public string Poster { get; set; }
        public List<MovieGenresModel> MoviesGenres { get; set; } = new List<MovieGenresModel>();
        public string TitleBrief
        {
            get
            {
                if (string.IsNullOrEmpty(Title))
                    return null;

                if (Title.Length > 60)
                    return Title.Substring(0, 60);

                else
                    return Title;
            }
        }
    }
}