using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WORLD_OF_DUEL_MASTERS.Models
{
    public class Card
    {
        [Key]
        public Guid CardID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Name")]
        public string Name { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Set")]
        public string Set { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Id")]
        public string Id { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("Civilizations")]
        public string Civilization { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Rarity")]
        public string Rarity { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Type")]
        public string Type { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Cost")]
        public string Cost { get; set; }

        [Column(TypeName = "nvarchar(400)")]
        [DisplayName("Text")]
        public string Text { get; set; }

        [Column(TypeName = "nvarchar(400)")]
        [DisplayName("Flavor")]
        public string Flavor { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Illustrator")]
        public string Illustrator { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Race")]
        public string Race { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Power")]
        public string Power { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Races0")]
        public string Races0 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Races1")]
        public string Races1 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Civilizations0")]
        public string Civilizations0 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Civilizations1")]
        public string Civilizations1 { get; set; }

        public Guid DeckID { get; set; }
        public virtual Deck Deck { get; set; }
    }
}
