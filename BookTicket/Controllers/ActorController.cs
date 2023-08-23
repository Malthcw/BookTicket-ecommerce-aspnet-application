﻿using BookTicket.data;
using Microsoft.AspNetCore.Mvc;

namespace BookTicket.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext _context;

        public ActorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actor.ToList();
            return View(data);
        }
    }
}
