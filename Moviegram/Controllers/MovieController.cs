using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moviegram.Repositories;
using Moviegram.Context;
using Moviegram.ViewModels;

namespace Moviegram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieRepository _movieRepository;

      
        public MovieController(IMovieRepository movieRepository)
        {
           _movieRepository = movieRepository;
        }

        /// <summary>
        /// Get ALL Movie List
        /// </summary>
        /// <returns>List of movies</returns>
        [HttpGet]
        [Route("GetMovies")]
        public IEnumerable<Movie> GetMovies()
        {
            return _movieRepository.GetMovies();
        }

        /// <summary>
        /// get list of movies using movie name
        /// </summary>
        /// <param name="MovieName">MoiveName</param>
        /// <returns>list of movies</returns>
        [HttpGet]
        [Route("GetMoviesByMovieName")]
        public IActionResult GetMovieByName(string MovieName)
        {
            var result = _movieRepository.GetMovieByName(MovieName);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        /// <summary>
        /// get movie details based on movie id
        /// </summary>
        /// <param name="MovieId"></param>
        /// <returns>Details of particular movie</returns>
        [HttpGet]
        [Route("GetMoviesDetailsByMovieId")]
        public IActionResult GetMovieDetails(int MovieId)
        {
            var result = _movieRepository.GetMovieDetails(MovieId);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

    }
}