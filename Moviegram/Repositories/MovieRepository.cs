using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moviegram.Context;
using Moviegram.ViewModels;

namespace Moviegram.Repositories
{

    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDBContext _context;

        public MovieRepository(MovieDBContext context)
        {
            _context = context;
        }

        public List<Movie> GetMovieByName(string MovieName)
        {
            return _context.Movies.Where(i => i.MovieName.Contains(MovieName)).ToList();
        }

        public FullMovieDetails GetMovieDetails(int MovieId)
        {
            var query = (from movie in _context.Movies
                        join details in _context.MoviesDetailss on movie.Id equals details.MovieId
                        where details.MovieId == MovieId
                        select new FullMovieDetails
                        {
                            Id = movie.Id,
                            MovieName = movie.MovieName,
                            ImageUrl = movie.ImageUrl,
                            ShowTime = movie.ShowTime,
                            Details = details.Details,
                            Director = details.Director,
                            Writer = details.Writer
                        });
            return query.FirstOrDefault();
        }

        public List<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

       
        }
    }

