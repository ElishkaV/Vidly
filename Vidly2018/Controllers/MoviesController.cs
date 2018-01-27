﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2018.Models;

namespace Vidly2018.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!"};

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content($"pageIndex = {pageIndex} & sortBy = {sortBy}");
        //}

        public ActionResult Index()
        {
            List<Movie> list = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shreck"},
                new Movie { Id = 2, Name = "Wall-e"}
            };
            return View(list);
        }
    }
}