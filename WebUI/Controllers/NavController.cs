﻿using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class NavController : Controller
    {

        private IBookRepository repository;

        public NavController(IBookRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu(string genre = null)   // PartialViewResult - часткове представлення (сторінки)
        {
            ViewBag.SelectedGenre = genre; // вказуємо вибрану категорію

            IEnumerable<string> genres = repository.Books
                .Select(book => book.Genre)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(genres);
        }

    }
}