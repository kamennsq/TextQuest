using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    abstract class Action
    {
        protected string capture;

        public Action(string initialCapture)
        {
            capture = initialCapture;
        }

        public string GetCapture()
        {
            return capture;
        }

        public abstract void Execute();
    }
}
