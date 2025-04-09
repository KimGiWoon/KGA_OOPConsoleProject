using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject
{
    public enum State
    {// 메뉴,  사용  , 사용확인,  버리기 , 버리기확인
        Menu, UseMenu, UseCheck, DropMenu, DropCheck
    }

    public class Inventory
    {
        private List<Items> items;
        private Stack<State> stack;
        public int selectIndex;

        public Inventory()
        {
            items = new List<Items>();
            stack = new Stack<State>();

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
            Console.SetCursorPosition(0, 2);
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

        public void Open()
        {
            stack.Push(State.Menu);

            while(stack.Count > 0)
            {
                Console.Clear();
                switch (stack.Peek())
                {
                    // 메뉴창
                    case State.Menu:
                        Menu();
                       break;
                    // 사용창
                    case State.UseMenu:
                        UseMenu();
                        break;
                    // 사용확인
                    case State.UseCheck:
                        UseCheck();
                        break;
                    // 버리기창
                    case State.DropMenu:
                        DropMenu();
                        break;
                    // 버리기확인
                    case State.DropCheck:
                        DropCheck();
                        break;

                }
            }
        }
        public void Menu()
        {
            ItemFindAll();

            Console.WriteLine("1. 사용하기");
            Console.WriteLine("2. 버리기");
            Console.WriteLine("3. 나가기");

            ConsoleKey keyDown = Console.ReadKey(true).Key;
            switch (keyDown)
            {
                case ConsoleKey.D1:
                    stack.Push(State.UseMenu);
                    break;
                case ConsoleKey.D2:
                    stack.Push(State.DropMenu);
                    break;
                case ConsoleKey.D3:
                    stack.Pop();
                    break;

            }
        }

        public void UseMenu()
        {
            ItemFindAll();
            Console.WriteLine();
            Console.WriteLine("사용할 아이템을 선택하세요.");
            Console.WriteLine("뒤로가기 ( 0클릭 )");

            ConsoleKey keyDown = Console.ReadKey(true).Key;
            if (keyDown == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)keyDown - (int)ConsoleKey.D1;
                if (select < 0 || items.Count <= select)
                {
                    Utility.PressAnyKey("해당 아이템은 없습니다.");
                }
                else
                {
                    selectIndex = select;
                    stack.Push(State.UseCheck);
                }
            }
        }

        public void UseCheck()
        {
            Console.SetCursorPosition(0, 2);
            Items selectItem = items[selectIndex];
            Console.WriteLine($"{selectItem.itemName} 을/를 사용하겠습니까?");
            Console.WriteLine("1. 네");
            Console.WriteLine("2. 아니요");

            ConsoleKey keyDown = Console.ReadKey(true).Key;
            switch(keyDown)
            {
                case ConsoleKey.D1:
                    selectItem.Use();
                    Utility.PressAnyKey($"{selectItem.itemName} 을/를 사용했습니다.");
                    ItemRemove(selectItem);
                    stack.Pop();
                    break;
                case ConsoleKey.D2:
                    stack.Pop();
                    break;
            }
        }

        public void DropMenu()
        {
            ItemFindAll();
            Console.WriteLine();
            Console.WriteLine("버릴 아이템을 선택하세요.");
            Console.WriteLine("뒤로가기 ( 0클릭 )");

            ConsoleKey keyDown = Console.ReadKey(true).Key;
            if (keyDown == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)keyDown - (int)ConsoleKey.D1;
                if(select < 0 || items.Count <= select)
                {
                    Utility.PressAnyKey("해당 아이템은 없습니다.");
                }
                else
                {
                    selectIndex = select;
                    stack.Push(State.DropCheck);
                }
            }
        }
        public void DropCheck()
        {
            Console.SetCursorPosition(0, 2);
            Items selectItem = items[selectIndex];
            Console.WriteLine($"{selectItem.itemName} 을/를 버리겠습니까?");
            Console.WriteLine("1. 네");
            Console.WriteLine("2. 아니요");

            ConsoleKey keyDown = Console.ReadKey(true).Key;
            switch (keyDown)
            {
                case ConsoleKey.D1:
                    Utility.PressAnyKey($"{selectItem.itemName} 을/를 버렸습니다.");
                    ItemRemove(selectItem);
                    stack.Pop();
                    break;
                case ConsoleKey.D2:
                    stack.Pop();
                    break;
            }
        }

    }
}
