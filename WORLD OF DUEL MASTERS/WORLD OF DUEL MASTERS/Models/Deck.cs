using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WORLD_OF_DUEL_MASTERS.Models
{
    public class Deck
    {
        [Key]
        public Guid DeckID { get; set; }
        public String Name { get; set; }


        public Guid AccountID { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }
}
