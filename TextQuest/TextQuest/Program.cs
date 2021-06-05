using System;
using System.Collections.Generic;

namespace TextQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GameConsoleInterface consoleInterface = new GameConsoleInterface();

            ItemFactory itemFactory = new MedallionFactory();

            PlayerCharacter player = new PlayerCharacter(200, 1f, "Джек");

            List<NonPlayerCharacter> npcs = new List<NonPlayerCharacter>();
            npcs.Add(new NonPlayerCharacter(100, 1f, "Бродяга", player, consoleInterface, itemFactory));

            Location startLocation = new Road("Дорога",
                "Впереди дорога, уходящая вдаль. По сторонам раскинулись поля. Слева виднеется густой лес." +
                "\nОглядевшись, ты понимаешь, что не одинок на этой дороге. Чуть поодаль виден чей-то силуэт.", 
                npcs, consoleInterface);

            consoleInterface.ChangeLocation(startLocation);

            consoleInterface.BackToLocation();
        }
    }
}
