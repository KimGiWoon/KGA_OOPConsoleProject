using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Scenes
{
    public class DungeonScene : MapManager
    {
        public DungeonScene()
        {
            mapName = SceneType.Dungeon;

            mapData = new string[]
            {
                "ΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔ",
                "Δ                 Δ",
                "ΔΔΔΔΔΔΔΔ          Δ",
                "       ΔΔΔΔΔ   ΔΔΔΔ",
                "           Δ   Δ   ",
                "           Δ   Δ   ",
                "           ΔΔΔΔΔ   ",
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
            gameObjects.Add(new Location('П', ConsoleColor.Blue, new Vecter2(1, 1), SceneType.Field));

            // 몬스터 생성
        }

        public override void Enter()
        {
            if(GameManager.beforeScene == SceneType.Field)
            {
                GameManager.Player.position = new Vecter2(1, 1);
            }
            GameManager.Player.map = map;

        }
    }
}
