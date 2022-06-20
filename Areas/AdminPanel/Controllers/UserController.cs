using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB.DAL;
using WEB.Models;

namespace WEB.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class UserController : Controller
    {
        private AppDbContext _context { get; }
        private IEnumerable<AppUser> users;
        public UserController(AppDbContext context)
        {
            _context = context;
            users = _context.Users.ToList();
        }
        public IActionResult Index()
        {
            return View(users);
        }
    }
}
