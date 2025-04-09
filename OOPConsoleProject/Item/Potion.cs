using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Item
{
    public class Potion : Items
    {
        private int healAmount;
        public int HealAmount { get { return healAmount; } set { healAmount = value; } }

        public Potion(ConsoleColor color, char shape, Vecter2 position, int healAmount) : base(color, shape, position)
        {
            this.healAmount = healAmount;
        }

        public override void Use()
        {
            GameManager.Player.HealLimit(HealAmount);
        }
    }
}
