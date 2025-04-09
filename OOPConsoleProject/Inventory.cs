using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject
{
    public class Inventory
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
            items[index].Use();
        }

        // 인벤토리 아이템 전체 출력
        public void ItemFindAll()
        {
            Console.WriteLine("===소유한 아이템====");
            if(items.Count == 0)
            {
                Console.WriteLine("아이템이 없어요");
            }
            for(int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0}. {1}",i+1, items[i].itemName);
            }
            Console.WriteLine("====================");
                
        }
    }
}
