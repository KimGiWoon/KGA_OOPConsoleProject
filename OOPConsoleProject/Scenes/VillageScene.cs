using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Item;

namespace OOPConsoleProject.Scenes
{
    public class VillageScene : MapManager
    {
        public VillageScene()
        {
            mapName = SceneType.Village;

            mapData = new string[]
            {
                "ΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔ",
                "Δ                 Δ",
                "Δ                 Δ",
                "Δ              ΔΔΔΔ",
                "ΔΔΔΔΔΔ         Δ   ",
                "     Δ         Δ   ",
                "     ΔΔΔΔΔΔΔΔΔΔΔ   ",
            };

            map = new bool[7, 19];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == 'Δ' ? false : true;
                }
            }

            // 필드로 가는 Game Object 생성
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Location('П', ConsoleColor.Red, new Vecter2(17, 1), SceneType.Field));
            gameObjects.Add(new Location('㉾', ConsoleColor.Cyan, new Vecter2(11, 4), SceneType.villageDialog));
            gameObjects.Add(new Location('П', ConsoleColor.DarkGreen, new Vecter2(6, 1), SceneType.MyRoom));
            // 신비한 구슬
            gameObjects.Add(new Bead(new Vecter2(10, 5)));
        }
        public override void Enter()
        {
            if (GameManager.beforeScene == SceneType.MyRoom)
            {
                GameManager.Player.position = new Vecter2(6, 1);    // 이전 씬에 맞게 플레이어 위치 세팅
            }
            else if (GameManager.beforeScene == SceneType.villageDialog)
            {
                GameManager.Player.position = new Vecter2(12, 5);   // 이전 씬에 맞게 플레이어 위치 세팅
            }
            else if (GameManager.beforeScene == SceneType.Field)
            {
                GameManager.Player.position = new Vecter2(17, 1);   // 이전 씬에 맞게 플레이어 위치 세팅
            }
            GameManager.Player.map = map;
        }
    }
}
