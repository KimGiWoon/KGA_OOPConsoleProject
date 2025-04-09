using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Item;

namespace OOPConsoleProject.Scenes
{
    public class MyRoomScene : MapManager
    {
        public MyRoomScene()
        {
            mapName = SceneType.MyRoom;

            mapData = new string[]
            {
                "ΔΔΔΔΔΔΔΔΔΔΔΔ",
                "Δ     Δ    Δ",
                "Δ     Δ    Δ",
                "ΔΔΔΔ       Δ",
                "Δ  Δ     ΔΔΔ",
                "Δ  ΔΔΔ   Δ  ",
                "Δ        Δ  ",
                "ΔΔΔΔΔΔΔΔΔΔ  ",
            };

            map = new bool[8, 12];
            for(int y= 0; y<map.GetLength(0); y++)
            {
                for(int x= 0; x<map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == 'Δ' ? false : true;
                }
            }
            // 마을로 가는 Game Object 생성
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Location('П', ConsoleColor.DarkGreen, new Vecter2(5, 6), SceneType.Village));

            // Player First Position
            GameManager.Player.position = new Vecter2(2, 2);
        }
        public override void Enter()
        {
            if (GameManager.beforeScene == SceneType.Village)
            {
                GameManager.Player.position = new Vecter2(5, 6);   // 이전 씬에 맞게 플레이어 위치 세팅
            }
            GameManager.Player.map = map;
        }


    }
}
