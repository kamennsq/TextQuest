using System;
using System.Collections.Generic;
using System.Text;

namespace TextQuest
{
    abstract class Character
    {
        protected int health;
        protected float moveSpeed;
        protected string name;

        public Character(int charHealth, float charMoveSpeed, string charName)
        {
            health = charHealth;
            moveSpeed = charMoveSpeed;
            name = charName;
        }

        public int GetHealth()
        {
            return health;
        }

        public float GetMoveSpeed()
        {
            return moveSpeed;
        }

        public void ChangeHealth(int newHealth)
        {
            health += newHealth;
        }

        public void ChangeMoveSpeed(float newMoveSpeed)
        {
            moveSpeed += newMoveSpeed;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public abstract void KillCharacter();
    }
}
