using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObjects
{
    public abstract class Items : GameObject
    {
        public string itemName;
        public string itemDescription;

        public Items(ConsoleColor color, char shape, Vecter2 position) : base(color, shape, position)
        {

        }

        public override void interact(Player player)
        {
            // 플레이어의 인벤토리에 아이템추가
            player.inventory.Add(this);
        }

        public abstract void Use();
        
    }
}
