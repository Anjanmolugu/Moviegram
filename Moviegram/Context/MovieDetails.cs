using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Moviegram.Context
{
    [Table("MovieDetails")]
    public class MovieDetails
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public string Director { get; set; }

        public string Writer { get; set; }

        public string Details { get; set; }
    }
}
