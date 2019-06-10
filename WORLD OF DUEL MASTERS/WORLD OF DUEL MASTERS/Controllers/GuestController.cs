using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WORLD_OF_DUEL_MASTERS.Models;

namespace WORLD_OF_DUEL_MASTERS.Controllers
{
    public class GuestController : Controller
    {
        private readonly MyDatabaseContext _databasecontext;


        public GuestController(MyDatabaseContext context)
        {
            _databasecontext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult HomePage()
        {
            return View();
        }

        public async Task<IActionResult> CardsGuest(string searching)
        {
            var displaycards = from s in _databasecontext.DMCards select s;
            if (searching != null)
            {
                displaycards = displaycards.Where(s => s.Name.Contains(searching));
            }
            //displaycards = displaycards.Skip(a);
            //displaycards = displaycards.Take(10);
            return View(await displaycards.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dMCard = await _databasecontext.DMCards
                .FirstOrDefaultAsync(m => m.CardID == id);
            if (dMCard == null)
            {
                return NotFound();
            }

            return View(dMCard);
        }
    }
}