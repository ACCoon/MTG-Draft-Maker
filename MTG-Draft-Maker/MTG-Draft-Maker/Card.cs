using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Draft_Maker
{
    class Card
    {
        private int id;
        private string name;
        private string set;
        private string rarity;

        public void Card(int id, string name, string set, string rarity)
        {
            this.id = id;
            this.name = name;
            this.set = set;
            this.rarity = rarity;
        }

        public int getID()
        {
            return id;
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getSet()
        {
            return set;
        }

        public void setSet(string set)
        {
            this.set = set;
        }

        public string getRarity()
        {
            return rarity;
        }

        public void setRarity(string rarity)
        {
            this.rarity = rarity;
        }
    }
}
