﻿using Movies.Web.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Web.Service
{
   public interface IMovies
    {
       // SearchResults GetAllSearchResults();

       SearchResults GetSearchResultsByTitle(string title);

        Details GetDetailsById(string id);

        SearchResults SearchResultByTitleandYear(string title, string startYear, string endYear);

    }
}
