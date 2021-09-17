using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft_Discard_WinformsApp.Classes
{
    public class Cards
    {
        private int CardID { get; set; }
        private string CardName { get; set; }
        private string ManaBase { get; set; }
        private List<string> CardTypes { get; set; }
        private List<string> CardTribes { get; set; }
        private List<int> CardAD { get; set; }
        private string CardRarity { get; set; }
        private string CardDescription { get; set; }
        private Sets CardSet { get; set; }
        public Cards()
        {

        }
        public Cards(int id, string name, List<string> type, List<string> tribe, string rarity, Sets CardSet, string manabase = "", int power = 0, int defence = 0, string description = "")
        {
            this.CardID = id;
            this.CardName = name;
            this.ManaBase = manabase;
            this.CardTypes = type;
            this.CardTribes = tribe;
            this.CardRarity = rarity;
            this.CardAD = new List<int>();
            this.CardAD.Add(power);
            this.CardAD.Add(defence);
            this.CardDescription = description;
            this.CardSet = CardSet;
        }

        public int getCardID()
        {
            return this.CardID;
        }
        public string getCardName()
        {
            return this.CardName;
        }
        public string getCardManabase()
        {
            return this.ManaBase;
        }
        public List<string> getCardTypes()
        {
            return this.CardTypes;
        }
        public List<string> getCardTribes()
        {
            return this.CardTribes;
        }
        public List<int> getCardAD()
        {
            return this.CardAD;
        }
        public string getCardDescription()
        {
            return this.CardDescription;
        }
        public string getCardRarity()
        {
            return this.CardRarity;
        }
        public Sets getCardSet()
        {
            return this.CardSet;
        }
    }
}
