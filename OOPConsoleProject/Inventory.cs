using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject
{
    public class Inventory : List<Items>
    {
        private List<Items> items;

        public Inventory()
        {
            items = new List<Items>();
        }
        // 인벤토리 아이템 삭제
        public void ItemRemove(Items item)
        {
            items.Remove(item);
        }

        // 인벤토리에서 원하는 아이템 삭제
        public void ItemAtRemove(int index)
        {
            items.RemoveAt(index);
        }

        // 인벤토리 아이템 추가
        public void ItemAdd(Items item)
        {
            items.Add(item);
        }
        // 인벤토리 아이템 사용
        public void ItemUse(int index)
        {
            this[index].Use();
        }
    }
}
