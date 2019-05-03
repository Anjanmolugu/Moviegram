using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviegram.Context
{
    public partial class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Movie> Movies { get; set; }

        public virtual DbSet<MovieDetails> MoviesDetailss { get; set; }
    }
}
