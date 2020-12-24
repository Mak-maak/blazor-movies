using System.Collections.Generic;

namespace BlazorMovie.Entities.DTOs
{
    public class IndexPageDTO
    {
        public List<MovieModel> Intheaters { get; set; }
        public List<MovieModel> UpcomingReleases { get; set; }
    }
}