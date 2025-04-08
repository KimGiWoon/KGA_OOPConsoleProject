using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.Player;

namespace OOPConsoleProject.Scenes
{
    public class TitleScene : BaseScene
    {
        PlayerBuider adventurer;
        PlayerBuider warrior;
        PlayerBuider wizard;
        PlayerBuider archer;
        PlayerBuider thief;

        public override void Render()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┃    < 나의 끝내주는 모험! >    ┃");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┃      1. 게임 시작             ┃");
            Console.WriteLine("┃      2. 게임 종료             ┃");
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
        public override void Resuit()
        {
            switch(keyDown)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("게임을 시작합니다.");
                    GameManager.SceneChange(SceneType.ClassChoice);
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("게임을 종료합니다.");
                    GameManager.GameEnd();
                    break;
            }
        }

        
    }
}
