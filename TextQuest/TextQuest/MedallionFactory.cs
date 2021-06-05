using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    class MedallionFactory : ItemFactory
    {
        public override Item GetItem()
        {
            return new Medallion("Медальон скорости", 200);
        }
    }
}
