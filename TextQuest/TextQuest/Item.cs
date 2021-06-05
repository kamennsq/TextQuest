using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    abstract class Item
    {
        protected string name;
        protected int cost;
        protected PlayerCharacter owner;

        public Item (string initialName, int initialCost)
        {
            name = initialName;
            cost = initialCost;
        }

        public void SetOwner(PlayerCharacter player)
        {
            owner = player;
        }

        public string GetName()
        {
            return name;
        }

        public int GetCost()
        {
            return cost;
        }

        public virtual void Sell()
        {
            TakeOff();
            owner.ChangeGold(cost);
            Console.WriteLine($"Предмет {name} был продан за {cost}");
        }

        public abstract void Equip();

        public abstract void TakeOff();
    }
}
