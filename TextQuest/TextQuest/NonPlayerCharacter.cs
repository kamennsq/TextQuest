using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    class NonPlayerCharacter : Character
    {
        private bool alreadyTalked;
        private Item reward;
        private PlayerCharacter player;
        private GameConsoleInterface consoleInterface;

        public NonPlayerCharacter(int health, float moveSpeed, string name, PlayerCharacter player,
            GameConsoleInterface consoleInterface, ItemFactory rewardFactory) : base(health, moveSpeed, name)
        {
            alreadyTalked = false;
            this.player = player;
            this.consoleInterface = consoleInterface;
            reward = rewardFactory.GetItem();
        }

        public override void KillCharacter()
        {
            Console.WriteLine($"{name} умирает!");
        }

        public void Talk()
        {
            Console.WriteLine();
            if (!alreadyTalked)
            {
                consoleInterface.ShowTextInConsole("Приветствую, путник!" +
                "\nЯ уже давно скитаюсь по дорогам нашей страны и видел много разных людей." +
                "\nНо ты мне нравишься. Поэтому я подарю тебе кое-что.");
                alreadyTalked = true;

                player.AddItem(reward);

                consoleInterface.ShowTextInConsole($"{name} протягивает тебе {reward.GetName()}.");
            }
            else
            {
                consoleInterface.ShowTextInConsole("Бродяга смотрит вдаль пустым взглядом. Ему явно больше нечего сказать тебе.");
            }

            consoleInterface.BackToLocation();
        }
    }
}
