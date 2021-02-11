using FoodieApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           //This passes the reviews for the top 5 Restaurants on to the Index page
            return View(Review.GetReviews());
        }

        [HttpGet] // On the get call, this simply loads the page and the form
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost] // on the post call, triggered by the submission of the form, the new suggestion is passed on to the ViewSuggestions View
        public IActionResult Submit(Suggestion newSuggestion)
        {
            if(ModelState.IsValid)
            {
                TempStorage.SubmitSuggestion(newSuggestion);
                return RedirectToAction("ViewSuggestions");
            }
            return View();
        }
        public IActionResult ViewSuggestions()
        {
            return View(TempStorage.Suggestions);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
