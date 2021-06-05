using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    class TalkAction : Action
    {
        private NonPlayerCharacter npc;

        public TalkAction(string capture, NonPlayerCharacter npc) : base(capture)
        {
            this.npc = npc;
        }

        public override void Execute()
        {
            npc.Talk();
        }
    }
}
