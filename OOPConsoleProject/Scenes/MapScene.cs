using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class MapScene : BaseScene
    {
        protected bool[,] map;
        protected string[] mapData;

        public override void Render()
        {
            MapCreate();
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

            
        //}

        //protected class Map
        //{
        //    public string[,] map;
        //}
      
    }
}
