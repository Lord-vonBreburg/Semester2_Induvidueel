using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft_Discard_WinformsApp.Classes
{
    public class Cards
    {
        private int ID;
        private string Name;
        private string Mana;
        private List<string> Types;
        private List<string> Tribes;
        private List<int> PowDef;
        private string Rarity;
        private string Description;
        private Sets CardSet;

        public Cards()
        {

        }
        public Cards(int id, string name, List<string> type, List<string> tribe, string rarity, Sets CardSet, List<int> PowDef, string manabase = "", string description = "")
        {
            this.ID = id;
            this.Name = name;
            this.Mana = manabase;
            this.Types = type;
            this.Tribes = tribe;
            this.Rarity = rarity;
            this.PowDef = PowDef;
            this.Description = description;
            this.CardSet = CardSet;
        }
        public int CardID
        {
            get
            {
                return this.ID;
            }
            set
            {
                this.ID = value;
            }
        }
        public string CardName
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public string CardMana
        {
            get
            {
                return this.Mana;
            }
            set
            {
                this.Mana = value;
            }
        }
        public List<string> CardTypes
        {
            get
            {
                return this.Types;
            }
            set
            {
                this.Types = value;
            }
        }
        public List<string> CardTribes
        {
            get
            {
                return this.Tribes;
            }
            set
            {
                this.Tribes = value;
            }
        }
        public List<int> CardPowDef
        {
            get
            {
                return this.PowDef;
            }
            set
            {
                this.PowDef = value;
            }
        }
        public string CardDescription
        {
            get
            {
                return this.Description;
            }
            set
            {
                this.Description = value;
            }
        }
        public string CardRarity
        {
            get
            {
                return this.Rarity;
            }
            set
            {
                this.Rarity = value;
            }
        }
        public Sets CardSetID
        {
            get
            {
                return this.CardSet;
            }
            set
            {
                this.CardSet = value;
            }
        }
    }
}
