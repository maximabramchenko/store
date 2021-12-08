﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Controllers
{
    public class SearchController1 : Controller


    {



        private readonly IBookRepository  bookRepository;

        public SearchController1(IBookRepository bookRepository)
        {

            this.bookRepository = bookRepository;
        
        }


        public IActionResult Index(string query)
        {
            var books = bookRepository.GetAllByTite(query);
            return View(books);
        }
    }
}
