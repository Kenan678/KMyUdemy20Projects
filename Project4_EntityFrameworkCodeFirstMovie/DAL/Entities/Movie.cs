﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFrameworkCodeFirstMovie.DAL.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string Category { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }


    }
}
