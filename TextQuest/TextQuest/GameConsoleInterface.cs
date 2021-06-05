using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    class GameConsoleInterface
    {
        private Location currentLocation;

        public void ChangeLocation(Location newLocation)
        {
            currentLocation = newLocation;
        }

        private void ChooseActionMethod()
        {
            Console.WriteLine();

            int actionOrder = -1;
            Console.WriteLine("Введите порядковый номер действия, чтобы его совершить или любое другое число для выхода из игры:");
            while (true)
            {
                try
                {
                    actionOrder = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неправильный порядковый номер. Попробуйте снова:");
                }
            }
            currentLocation.ExecuteActionByOrder(actionOrder);
        }

        public void BackToLocation()
        {
            Console.WriteLine();
            Console.WriteLine("Вы находитесь на локации " + currentLocation.GetName());
            Console.WriteLine("Возможные действия: ");

            int i = 0;
            while (!currentLocation.GetActionCaptureByOrder(i).Equals("No such action found"))
            {
                Console.WriteLine((i + 1) + ". " + currentLocation.GetActionCaptureByOrder(i));
                i++;
            }

            ChooseActionMethod();
        }

        public void ShowTextInConsole(string text)
        {
            Console.WriteLine();
            Console.WriteLine(text);
        }
    }
}
