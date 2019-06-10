using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WORLD_OF_DUEL_MASTERS.Models;

namespace WORLD_OF_DUEL_MASTERS.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyDatabaseContext _context;

        public AdminController(MyDatabaseContext context)
        {
            _context = context;
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("UserName")=="Admin"&& HttpContext.Session.GetString("Password") == "Admin")
            {
                return View(await _context.DMCards.ToListAsync());
                
            }
            return RedirectToAction("Login", "Account");
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dMCard = await _context.DMCards
                .FirstOrDefaultAsync(m => m.CardID == id);
            if (dMCard == null)
            {
                return NotFound();
            }

            return View(dMCard);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CardID,Name,Set,Id,Civilization,Rarity,Type,Cost,Text,Flavor,Illustrator,Race,Power,Races0,Races1,Civilizations0,Civilizations1")] DMCard dMCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dMCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dMCard);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dMCard = await _context.DMCards.FindAsync(id);
            if (dMCard == null)
            {
                return NotFound();
            }
            return View(dMCard);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CardID,Name,Set,Id,Civilization,Rarity,Type,Cost,Text,Flavor,Illustrator,Race,Power,Races0,Races1,Civilizations0,Civilizations1")] DMCard dMCard)
        {
            if (id != dMCard.CardID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dMCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DMCardExists(dMCard.CardID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dMCard);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dMCard = await _context.DMCards
                .FirstOrDefaultAsync(m => m.CardID == id);
            if (dMCard == null)
            {
                return NotFound();
            }

            return View(dMCard);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dMCard = await _context.DMCards.FindAsync(id);
            _context.DMCards.Remove(dMCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DMCardExists(int id)
        {
            return _context.DMCards.Any(e => e.CardID == id);
        }
    }
}
