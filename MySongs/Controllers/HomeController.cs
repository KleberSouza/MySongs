using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySongs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MySongs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            int UserId = int.Parse(User.Claims.ElementAt(1).Value);

            var eventos = _context.Eventos
                .Include(t => t.Grupo1)
                .Include(t => t.Grupo2)
                .Where(c => (c.Grupo1.UsuarioId == UserId || c.Grupo2.UsuarioId == UserId) && c.Data > DateTime.Now)
                .ToList();

            if(eventos.Count > 0)
                ViewBag.Eventos = eventos;

            return View();
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
