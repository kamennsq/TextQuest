using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    class PlayerCharacter : Character
    {
        private int gold;
        private List<Item> items = new List<Item>();

        public PlayerCharacter(int health, float moveSpeed, string name) : base(health, moveSpeed, name)
        {
            gold = 0;
        }

        public override void KillCharacter()
        {
            Console.WriteLine($"Главный герой {name} умирает!");
        }

        public void ChangeGold(int gold)
        {
            this.gold += gold;
        }

        public void AddItem(Item newItem)
        {
            items.Add(newItem);
        }
    }
}
