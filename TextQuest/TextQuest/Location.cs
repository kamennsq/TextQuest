using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    abstract class Location
    {
        protected string name;
        protected List<NonPlayerCharacter> characters = new List<NonPlayerCharacter>();
        protected List<Action> actions = new List<Action>();
        protected string observeText;
        protected GameConsoleInterface consoleInterface;

        public Location(string initialName, string observeText, List<NonPlayerCharacter> initialCharacters, GameConsoleInterface consoleInterface)
        {
            name = initialName;
            this.observeText = observeText;
            this.consoleInterface = consoleInterface;
            FillCharacterList(initialCharacters);
            FillActionList();
        }

        protected abstract void FillActionList();

        private void FillCharacterList(List<NonPlayerCharacter> initialCharacters)
        {
            foreach (NonPlayerCharacter tempCharacter in initialCharacters)
            {
                characters.Add(tempCharacter);
            }
        }

        public string GetName()
        {
            return name;
        }

        public void ExecuteActionByOrder(int order)
        {
            if (order - 1 >= 0 && actions.Count > order - 1)
            {
                actions[order - 1].Execute();
            }
        }

        public string GetActionCaptureByOrder(int order)
        {
            if (order >= 0 && actions.Count > order)
            {
                return actions[order].GetCapture();
            }
            else
            {
                return "No such action found";
            }
        }

        public abstract void ObserveLocation();
    }
}
