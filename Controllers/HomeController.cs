using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RESTauranter.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace RESTauranter.Controllers
{
    public class HomeController : Controller
    {
        private ReviewContext _context;

        public HomeController(ReviewContext context)
        {
            _context = context;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Recensione rev)
        {
            if(ModelState.IsValid)
            {
                _context.Add(rev);
                _context.SaveChanges();
                return RedirectToAction("Show");
            }
            return View("Index");
        }

        [HttpGet]
        [Route("show")]
        public IActionResult Show()
        {
            List<Recensione> AllReviews = _context.reviews.OrderByDescending(s => s.created_at).ToList();
            ViewBag.Reviews = AllReviews;
            return View();
        }
    }
}
