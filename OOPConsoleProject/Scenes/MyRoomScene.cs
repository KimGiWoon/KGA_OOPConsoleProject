using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class MyRoomScene : FieldScene
    {
        public MyRoomScene()
        {

            mapData = new string[]
            {
                "############",
                "#          #",
                "#          #",
                "#          #",
                "#          #",
                "#          #",
                "#          #",
                "############",
            };

            map = new bool[8, 12];
            for(int y= 0; y<map.GetLength(0); y++)
            {
                for(int x= 0; x<map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
            //GameManager.Player.position = new Vecter2(1, 1);
            //GameManager.Player.map = map;
        }
        


    }
}
