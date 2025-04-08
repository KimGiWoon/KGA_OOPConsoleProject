using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class VillageScene : BaseScene
    {
        public override void Render()
        {
            Utility.SlowTextPrint("이곳은 내가 태어난 마을이다.");
            Utility.SlowTextPrint("아침부터 마을사람들이 북적인다.");
            Console.WriteLine();
            Utility.TextPrint("1. 필드로 나간다.");
            
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
                    Utility.TextPrint("필드로 나갑니다.");
                    Utility.SlowTextPrint("뚜벅...뚜벅....뚜벅....");
                    Utility.PressAnyKey("");
                    GameManager.SceneChange(SceneType.Field);
                    break;
            }
        }

       
    }
}
