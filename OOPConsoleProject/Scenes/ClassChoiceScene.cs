using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.Player;

namespace OOPConsoleProject.Scenes
{
    public class ClassChoiceScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┃   * 직업을 선택해주세요. *    ┃");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┃      1. 모험가                ┃");
            Console.WriteLine("┃      2. 전사                  ┃");
            Console.WriteLine("┃      3. 마법사                ┃");
            Console.WriteLine("┃      4. 궁수                  ┃");
            Console.WriteLine("┃      5. 도적                  ┃");
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
            switch(keyDown)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("모험가를 선택하셨습니다.");
                    break;
                    
                    
                    
            }
        }

    }
}
