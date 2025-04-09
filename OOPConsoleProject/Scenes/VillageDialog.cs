using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Item;

namespace OOPConsoleProject.Scenes
{
    public class VillageDialog : BaseScene
    {
        Inventory inventory;
        Bead bead;
        
        public VillageDialog()
        {
            mapName = SceneType.Village;
        }
        public override void Render()
        {
            Utility.SlowTextPrint("시끌~~! 시끌~~!");
            Utility.SlowTextPrint("북적...북적...");
            Console.WriteLine();
            Utility.SlowTextPrint("상인 : 아이고 어서오세요~~");
            Utility.SlowTextPrint("상인 : 내 아직 정리가 덜 돼서 그런데");
            Utility.SlowTextPrint("상인 : 내일 다시 와주면 안되겠나?;;");
            Utility.SlowTextPrint("상인 : ...우당......우당탕탕;;...");
            Console.WriteLine();
            Utility.SlowTextPrint("상인 : 자네..혹시? 주변에 구슬 떨어진거 못봤나?");
            Console.WriteLine();
            Utility.TextPrint("1. 음...잘 모르겠어요");
            Utility.TextPrint("2. 다음에 올께요");
           
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
                    Console.WriteLine("상인 : 아휴,,,, 알겠네....");
                    Utility.PressAnyKey("상점을 나갑니다.");
                    GameManager.SceneChange(SceneType.Village);
                    break;
                case ConsoleKey.D2:
                    Utility.PressAnyKey("상점을 나갑니다.");
                    GameManager.SceneChange(SceneType.Village);
                    break;
            }
        }

       
    }
}
