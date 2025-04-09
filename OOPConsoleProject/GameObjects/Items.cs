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

        public Items(char shape, Vecter2 position) : base(ConsoleColor.Magenta, shape, position, true)
        {
        }

        public override void Interact(Player player)
        {
            // 플레이어의 인벤토리에 아이템추가
            player.Inventory.ItemAdd(this);
        }

        public abstract void Use();
        
    }
}
