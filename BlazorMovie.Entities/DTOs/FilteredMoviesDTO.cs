﻿namespace BlazorMovie.Entities.DTOs
{
    public class FilteredMoviesDTO
    {
        public int Page { get; set; } = 1;
        public int RecordsPerPage { get; set; } = 10;
        public PaginationDTO Pagination
        {
            get { return new PaginationDTO() { Page = Page, RecordsPerPage = RecordsPerPage }; }
        }
        public string Title { get; set; }
        public int GenreID { get; set; }
        public bool InTheaters { get; set; }
        public bool UpcomingReleases { get; set; }
    }
}