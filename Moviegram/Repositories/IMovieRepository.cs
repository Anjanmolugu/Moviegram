using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moviegram.Context;
using Moviegram.ViewModels;

namespace Moviegram.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetMovies();

        List<Movie> GetMovieByName(string MovieName);

        FullMovieDetails GetMovieDetails(int MovieId);

    }
}
