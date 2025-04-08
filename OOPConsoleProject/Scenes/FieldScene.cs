using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Scenes
{
    public class FieldScene : BaseScene
    {
        private bool[,] map;
        private string[] mapData;
        // Game Object List Create
        private List<GameObject> gameObjects;

        public FieldScene()
        {
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
            for(int y =0; y < map.GetLength(0); y++)
            {
                for(int x =0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == 'Δ' ? false : true; 
                }
            }

            GameManager.Player.position = new Vecter2(1, 1);
            GameManager.Player.map = map;

            // 마을로 가는 Game Object 생성
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Location('П',new Vecter2(1,1), SceneType.Village));
        }
        
        public override void Render()
        {
            MapCreate();
            foreach(GameObject gameObj in gameObjects)
            {
                gameObj.Print();
            }
            GameManager.Player.Print();

            Console.SetCursorPosition(0, map.GetLength(0) + 1);
            GameManager.Player.StatusPint();
        }

        public override void Input()
        {
            keyDown = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            GameManager.Player.Move(keyDown);
        }

        public override void Result()
        {
            foreach(GameObject gameObj in gameObjects)
            {
                // 게임오브젝트 위치와 플레이어의 위치가 같으면 상호작용
                if (GameManager.Player.position == gameObj.position) 
                {
                    gameObj.interact(GameManager.Player);
                }
            }
        }

        private void MapCreate()
        {
            Console.SetCursorPosition(0, 0);
            for(int y = 0; y < map.GetLength(0); y++)
            {
                for(int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y,x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('Δ');
                    }
                }
                Console.WriteLine();
            }
        }
        
    }
}
