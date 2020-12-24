using BlazorMovie.Entities;
using System.Collections.Generic;

namespace BlazorMovies.Frontend.Helpers
{
    public interface IRepository
    {
        List<MovieModel> GetMovies();
    }
}
