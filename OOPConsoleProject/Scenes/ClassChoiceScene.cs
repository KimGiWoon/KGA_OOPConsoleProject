using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPConsoleProject.Scenes
{
    public class ClassChoiceScene : BaseScene
    {
        //PlayerBuider adventurerBuilder = new PlayerBuider();
        //PlayerBuider warriorBuilder = new PlayerBuider();
        //PlayerBuider wizardBuilder = new PlayerBuider();
        //PlayerBuider archerBuilder = new PlayerBuider();
        //PlayerBuider thiefBuilder = new PlayerBuider();

        private static Player player;
        public static Player Player { get { return player; } }

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
                    Console.Clear();
                    Utility.TextPrint("모험가를 선택하셨습니다.");
                    Utility.TextPrint("신의 가호가 함께하길....");
                    Utility.PressAnyKey("");
                    //adventurerBuilder.SetClass("모험가")
                    //                 .SetHp(100)
                    //                 .SetStr(5)
                    //                 .SetDex(2)
                    //                 .SetInt(1)
                    //                 .SetLuck(2);
                    //Player player = adventurerBuilder.Build();
                    //GameManager.SceneChange(SceneType.MyRoom);
                    break;

                    

                    
                    
            }
        }

    }
}
