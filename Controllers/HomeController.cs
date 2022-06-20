using WEB.DAL;
using WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WEB.ViewModels;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel
            {
                Slides= _context.Slides.ToList(),
                Summary = _context.Summary.FirstOrDefault(),
                Categories = _context.Categories.Where(c => !c.IsDeleted).ToList(),
                Products=_context.Products.Where(c=>!c.isDeleted)
                .Include(p=>p.Images).Include(p=>p.Category).ToList(),
             };
            return View(home);
        }
    }
}
