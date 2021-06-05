using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    class ObserveAction : Action
    {
        private Location location;

        public ObserveAction(string capture, Location location) : base(capture)
        {
            this.location = location;
        }

        public override void Execute()
        {
            location.ObserveLocation();
        }
    }
}
