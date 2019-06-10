using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WORLD_OF_DUEL_MASTERS.Models;

namespace WORLD_OF_DUEL_MASTERS.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<DMCard> DMCards { get; set; }

        public DbSet<WORLD_OF_DUEL_MASTERS.Models.Card> Card { get; set; }

        public DbSet<WORLD_OF_DUEL_MASTERS.Models.Deck> Deck { get; set; }

    }
}
