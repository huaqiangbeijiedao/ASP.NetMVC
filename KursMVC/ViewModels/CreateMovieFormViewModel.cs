﻿using KursMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace KursMVC.ViewModels
{
    public class CreateMovieFormViewModel
    {
        public Movie Movie;
        public IEnumerable<Genre> Genres;
    }
}