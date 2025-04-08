using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class FieldScene : BaseScene
    {
        private bool[,] map;
        private string[] mapData;

        public FieldScene()
        {
            mapData = new string[]
            {
                "ΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔΔ",
                "Δ            Δ  Δ",
                "Δ      ΔΔΔΔ     Δ",
                "ΔΔΔΔ   Δ  ΔΔΔΔΔΔΔ",
                "Δ      Δ         ",
                "ΔΔΔΔΔΔΔΔ         ",
            };

            map = new bool[6, 17];
            for(int y =0; y < map.GetLength(0); y++)
            {
                for(int x =0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == 'Δ' ? false : true; 
                }
            }

            GameManager.Player.position = new Vecter2(1, 1);
            GameManager.Player.map = map;
        }
        
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
