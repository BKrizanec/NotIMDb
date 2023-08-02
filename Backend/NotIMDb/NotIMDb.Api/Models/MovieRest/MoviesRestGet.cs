﻿using NotIMDb.Api.Models.ReviewRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotIMDb.Api.Models.MovieRest
{
    public class MoviesRestGet
    {
        public List<MovieRestGet> AllMovieRests { get; set; }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
    }
}