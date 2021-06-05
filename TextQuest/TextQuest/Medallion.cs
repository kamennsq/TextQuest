using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    class Medallion : Item
    {
        private float newSpeed;
        public Medallion(string initialName, int initialCost) : base(initialName, initialCost)
        {
            newSpeed = 2f;
        }

        public override void Equip()
        {
            owner.ChangeMoveSpeed(newSpeed);
        }

        public override void TakeOff()
        {
            owner.ChangeMoveSpeed(-newSpeed);
        }
    }
}
