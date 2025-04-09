using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace OOPConsoleProject.Scenes
{
    public enum playerClass
    {
        모험가, 전사, 궁수, 마법사
    }
    public class ClassChoiceScene : BaseScene
    {
        
        private Player player;
        public Player Player { get { return player; } }


        public override void Render()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┃   * 직업을 선택해주세요. *    ┃");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┃         1. 모험가             ┃");
            Console.WriteLine("┃         2. 전사               ┃");
            Console.WriteLine("┃         3. 마법사             ┃");
            Console.WriteLine("┃         4. 궁수               ┃");
            Console.WriteLine("┃         5. 도적               ┃");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
        public override void Input()
        {
            keyDown = Console.ReadKey(true).Key;
        }
        public override void Update()
        {

        }
        public override void Result()
        {
            switch (keyDown)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Utility.TextPrint("모험가를 선택하셨습니다.");
                    Utility.TextPrint("신의 가호가 함께하길....");
                    
                    break;






            }
        }

    }
}
