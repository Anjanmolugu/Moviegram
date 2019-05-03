using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Moviegram.Context
{
    [Table("Movie")]
    public class Movie
    {
        public int Id { get; set; }

        public string MovieName { get; set; }

        public string ImageUrl { get; set; }

        public DateTime? ShowTime { get; set; } 
    }
}
