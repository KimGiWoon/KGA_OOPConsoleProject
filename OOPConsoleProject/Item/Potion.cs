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

        public Potion( Vecter2 position, int healAmount) : base('♥', position)
        {
            this.healAmount = healAmount;

            itemName = "포션";
            itemDescription = "플레이어의 체력을 조금 회복하게 해주는 빨간 물약";
        }

        public override void Use()
        {
            GameManager.Player.Heal(HealAmount);
        }
    }
}
