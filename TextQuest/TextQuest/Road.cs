using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    class Road : Location
    {

        public Road(string initialName, string observeText, List<NonPlayerCharacter> initialCharacters, GameConsoleInterface consoleInterface) 
            : base(initialName, observeText, initialCharacters, consoleInterface)
        {

        }

        public override void ObserveLocation()
        {
            consoleInterface.ShowTextInConsole(observeText);
            consoleInterface.BackToLocation();
        }

        protected override void FillActionList()
        {
            actions.Add(new ObserveAction("Осмотреться", this));

            for (int i = 0; i < characters.Count; i++)
            {
                actions.Add(new TalkAction($"Поговорить с персонажем {characters[i].GetName()}", characters[i]));
            }
        }
    }
}
