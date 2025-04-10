using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Item;

namespace OOPConsoleProject.Scenes
{
    public class FieldScene : MapManager
    {
        public FieldScene()
        {
            mapName = SceneType.Field;
            

            mapData = new string[]
            {
                "ΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔ",
                "Δ             Δ   Δ",
                "Δ      ΔΔΔΔ       Δ",
                "ΔΔΔΔ   Δ  ΔΔΔΔΔΔΔΔΔ",
                "Δ      Δ           ",
                "ΔΔΔΔΔΔΔΔ           ",
            };

            map = new bool[6, 19];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == 'Δ' ? false : true;
                }
            }

            
            // 마을로 가는 Game Object 생성
            gameObjects = new List<GameObject>();
            

            gameObjects.Add(new Location('П', ConsoleColor.Red, new Vecter2(1, 1), SceneType.Village));
            gameObjects.Add(new Location('П', ConsoleColor.Blue, new Vecter2(17, 1), SceneType.Dungeon));

            // 아이템 생성
            gameObjects.Add(new Potion(new Vecter2(1, 4), 30));
            gameObjects.Add(new Potion(new Vecter2(4, 2), 30));
            gameObjects.Add(new Potion(new Vecter2(15, 2), 30));

            // 몬스터 생성
            //gameObjects.Add(new Monster("버섯병사", 50, 2, new Vecter2(4, 3), SceneType.Battle));
            //gameObjects.Add(new Monster("버섯병사", 50, 2, new Vecter2(17, 2), SceneType.Battle));
            //gameObjects.Add(new Monster("버섯쫄병", 40, 2, new Vecter2(12, 2), SceneType.Battle));
        }

        public override void Enter()
        {
            if(GameManager.beforeScene == SceneType.Village)    
            {
                GameManager.Player.position = new Vecter2(1, 1);    // 이전 씬에 맞게 플레이어 위치 세팅
            }
            else if(GameManager.beforeScene == SceneType.Dungeon)
            {
                GameManager.Player.position = new Vecter2(17, 1);   // 이전 씬에 맞게 플레이어 위치 세팅
            }
            GameManager.Player.map = map;
        }
    }
}
