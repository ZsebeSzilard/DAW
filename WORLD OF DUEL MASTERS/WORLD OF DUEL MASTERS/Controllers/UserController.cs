using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WORLD_OF_DUEL_MASTERS.Models;

namespace WORLD_OF_DUEL_MASTERS.Controllers
{
    public class UserController : Controller
    {
        //MyDatabaseContext
        //
        private readonly MyDatabaseContext _databasecontext;


        public UserController(MyDatabaseContext databasecontext)
        {
            _databasecontext = databasecontext;
           
        }
        public IActionResult Index()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View();
        }

        public IActionResult PrivacyUser()
        {

            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View();
        }

        public IActionResult HomePage()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View();
        }

        public async Task<IActionResult> CardsUser(string searching)
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            var displaycards = from s in _databasecontext.DMCards select s;
            if (searching != null)
            {
                displaycards = displaycards.Where(s => s.Name.Contains(searching));
            }
            //displaycards = displaycards.Skip(a);
            //displaycards = displaycards.Take(10);
            return View(await displaycards.ToListAsync());
        }

        public async Task<IActionResult> CardDetailsUser(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var card = await _databasecontext.DMCards
                .FirstOrDefaultAsync(m => m.CardID == id);
            if (card == null)
            {
                return NotFound();
            }
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View(card);
        }
        public ActionResult DashBoardUser()
        {
            if (HttpContext.Session.GetString("UserName") != null && HttpContext.Session.GetString("Password") != null)
            {
                ViewBag.Message = HttpContext.Session.GetString("UserName");
                return View();
            }
            else
            {
                return RedirectToAction("HomePage", "Guest");
            }
        }
        public async Task<IActionResult> Profile()
        {
            string name = Convert.ToString(HttpContext.Session.GetString("UserName"));

            var account = await _databasecontext.Accounts
                .FirstOrDefaultAsync(m => m.Username == name);
            if (account == null)
            {
                return NotFound();
            }
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View(account);
        }

        

        public IActionResult CreateDeck()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateDeck(Deck deck)
        {
            string name = Convert.ToString(HttpContext.Session.GetString("UserName"));

            Account account= await  _databasecontext.Accounts
                .FirstOrDefaultAsync(m => m.Username == name);

            if (ModelState.IsValid)
            {

                deck.AccountID = account.AccountID;
                _databasecontext.Add(deck);
                _databasecontext.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("DashBoardUser");

            }

            return View();
        }


        public async Task<IActionResult> DeckUser()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");


            var displaydecks = _databasecontext.Deck;
            string name = Convert.ToString(HttpContext.Session.GetString("UserName"));
            Account CurrentAccount = await _databasecontext.Accounts
                .FirstOrDefaultAsync(m => m.Username == name);

            var Decks =_databasecontext.Deck.Where(t => t.AccountID.ToString().ToLower() == CurrentAccount.AccountID.ToString().ToLower()).ToList();

            return View(Decks);
        }

        public  IActionResult DetailDeckUser(Guid? id)
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");

            

            var Cards = _databasecontext.Card.Where(t => t.DeckID.ToString().ToLower() == id.ToString().ToLower()).ToList();

            
            return View(Cards);
        }

        public IActionResult EditDeckUser(Guid? id)
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");

            Deck DeckWeWillModify = _databasecontext.Deck
                .FirstOrDefault(s => s.DeckID.ToString().ToLower() == id.ToString().ToLower());

            HttpContext.Session.SetString("DeckName", DeckWeWillModify.Name.ToString());


            var Cards = _databasecontext.Card.Where(t => t.DeckID.ToString().ToLower() == id.ToString().ToLower()).ToList();


            return View(Cards);
        }
        public async Task<IActionResult> AddCard(string searching)
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            var displaycards = from s in _databasecontext.DMCards select s;
            if (searching != null)
            {
                displaycards = displaycards.Where(s => s.Name.Contains(searching));
            }
            return View(await displaycards.ToListAsync());
        }
        public async Task<IActionResult> AddToYourDeckCard(int? id)
        {
            if (id == null|| HttpContext.Session.GetString("UserName")==null)
            {
                return NotFound();
            }
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            if (id != null)
            {
                string deckname = Convert.ToString(HttpContext.Session.GetString("DeckName"));

                Deck DeckToAdd = await _databasecontext.Deck
                    .FirstOrDefaultAsync(m => m.Name == deckname);


                DMCard CardToCopy = await _databasecontext.DMCards
                    .FirstOrDefaultAsync(m => m.CardID == id);
               

                Card NewCard = new Card();
                NewCard.Civilization = CardToCopy.Civilization;
                NewCard.Civilizations0 = CardToCopy.Civilizations0;
                NewCard.Civilizations1 = CardToCopy.Civilizations1;
                NewCard.Cost = CardToCopy.Cost;
                NewCard.Text = CardToCopy.Text;
                NewCard.Type = CardToCopy.Type;
                NewCard.Flavor = CardToCopy.Flavor;
                NewCard.Id = CardToCopy.Id;
                NewCard.Illustrator = CardToCopy.Illustrator;
                NewCard.Name = CardToCopy.Name;
                NewCard.Rarity = CardToCopy.Rarity;
                NewCard.Set = CardToCopy.Set;
                NewCard.Race = CardToCopy.Race;
                NewCard.Races0 = CardToCopy.Races0;
                NewCard.Races1 = CardToCopy.Races1;
                NewCard.Power = CardToCopy.Power;
                NewCard.DeckID = DeckToAdd.DeckID;

                _databasecontext.Card.Add(NewCard);
                _databasecontext.SaveChanges();
                return RedirectToAction("DeckUser", "User");
            }
            return RedirectToAction("Homepage", "Guest");

        }




        public async Task<IActionResult> DeleteDeckUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dMCard = await _databasecontext.Deck
                .FirstOrDefaultAsync(m => m.DeckID.ToString() == id.ToString());
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
            var dMCard = await _databasecontext.DMCards.FindAsync(id);
            _databasecontext.DMCards.Remove(dMCard);
            await _databasecontext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}