using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviegram.ViewModels
{
    public class FullMovieDetails
    {
        public int Id { get; set; }

        public string MovieName { get; set; }

        public string ImageUrl { get; set; }

        public DateTime? ShowTime { get; set; }

        public string Director { get; set; }

        public string Writer { get; set; }

        public string Details { get; set; }
    }
}
