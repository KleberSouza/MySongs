using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MySongs.Models;

namespace MySongs.Controllers
{
    public class EventosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var eventos = await _context.Eventos.ToListAsync();
            return View(eventos);
        }

        public IActionResult Create()
        {
            ViewData["Grupo1Id"] = new SelectList(_context.Grupos, "Id", "Nome");
            ViewData["Grupo2Id"] = new SelectList(_context.Grupos, "Id", "Nome");
            return View();
        }

        // POST: Musicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Descricao,Grupo1Id,Grupo2Id")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(evento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Grupo1Id"] = new SelectList(_context.Grupos, "Id", "Nome", evento.Grupo1Id);
            ViewData["Grupo2Id"] = new SelectList(_context.Grupos, "Id", "Nome", evento.Grupo2Id);
            return View(evento);
        }
    }
}
