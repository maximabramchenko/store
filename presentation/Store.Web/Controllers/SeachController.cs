using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Controllers
{
    public class SeachController : Controller
    { 

        private readonly IBookRepository bookRepository;


        public SeachController(IBookRepository bookRepository)
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
