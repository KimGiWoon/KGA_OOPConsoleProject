using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class RoomDialog : BaseScene
    {
        public RoomDialog()
        {
            mapName = SceneType.RoomDialog;
        }
        public override void Render()
        {
            Utility.SlowTextPrint("화창한 아침이다.");
            Utility.SlowTextPrint("햇빛이 따스하게 내리쮜어 눈을 비춘다.");
            Console.WriteLine();
            Utility.SlowTextPrint("플레이어 : 아~~~~ 상쾌한 아침이다.");
            Utility.SlowTextPrint("플레이어 : 조금만 더 자고 싶은데 일어나야겠지?");
            Utility.SlowTextPrint("1. 일어난다");
            Utility.SlowTextPrint("2. 좀 더 잘래...");
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
                    Utility.TextPrint("눈을 부비며 일어납니다.");
                    Utility.PressAnyKey("");
                    GameManager.SceneChange(SceneType.MyRoom);
                    break;
                case ConsoleKey.D2:
                    Utility.TextPrint("플레이어는 영원히 잠들었습니다....");
                    Utility.PressAnyKey("게임을 종료합니다.");
                    GameManager.GameEnd();
                    break;
            }
        }

      
    }
}
