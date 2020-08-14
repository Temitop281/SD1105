using System;
using System.Collections.Generic;

namespace Sakila.Models
{
    public partial class Actor
    {
        public Actor()
        {
            FilmActor = new HashSet<FilmActor>();
        }

        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<FilmActor> FilmActor { get; set; }
    }
}
