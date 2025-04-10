using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Scenes
{
    public abstract class MapManager : BaseScene
    {
        protected bool[,] map;
        protected string[] mapData;
        // Game Object List Create

        protected List<GameObject> gameObjects;      

        public override void Render()
        {
            MapCreate();
            foreach(GameObject gameObj in gameObjects)
            {
                gameObj.Print();
            }

            GameManager.Player.Print();
            // 플레이어 상태창 출력
            Console.SetCursorPosition(0, map.GetLength(0) + 1);
            GameManager.Player.StatusPint();
            
        }

        public override void Input()
        {
            keyDown = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            GameManager.Player.playerAction(keyDown);
        }

        public override void Result()
        {
            foreach(GameObject gameObj in gameObjects)
            {
                // 게임오브젝트 위치와 플레이어의 위치가 같으면 상호작용
                if (GameManager.Player.position == gameObj.position) 
                {
                    gameObj.Interact(GameManager.Player);
                    if (gameObj.disposable == true)
                    {
                        gameObjects.Remove(gameObj);
                    }
                    break;
                }
            }
            
        }

        private void MapCreate()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
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
        //protected class MapBuilder
        //{
        //    public int column = 8;
        //    public int row = 8;

        //    public string[] map = new string[];
        //    public MapBuilder()
        //    {
        //        map = new string[column][row];
        //    }
        //}
        //protected Map Build()
        //{
        //    Map map = new Map();
        //    map =


        //    }

        //protected class Map
        //{
        //    public string[,] map;
        //}

    }
}
