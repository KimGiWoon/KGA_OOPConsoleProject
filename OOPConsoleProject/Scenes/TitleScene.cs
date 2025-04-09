using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TitleScene : BaseScene
    {
        public TitleScene()
        {
            mapName = SceneType.Title;
        }

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
        public override void Result()
        {
            switch(keyDown)
            {
                case ConsoleKey.D1:
                    GameManager.SceneChange(SceneType.RoomDialog);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("게임을 종료합니다.");
                    GameManager.GameEnd();
                    break;
            }
        }

        
    }
}
