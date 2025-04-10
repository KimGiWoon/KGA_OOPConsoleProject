﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class GameClearScene : BaseScene
    {
        public GameClearScene()
        {
            mapName = SceneType.GameClear;
        }
        public override void Render()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┃     <  Game Over Clear!  >    ┃");
            Console.WriteLine("┃        축하합니다~!!          ┃");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┃      1. 다시 시작             ┃");
            Console.WriteLine("┃      2. 게임 종료             ┃");
            Console.WriteLine("┃                               ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
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
                    GameManager.GameStart();
                    break;
                case ConsoleKey.D2:
                    GameManager.GameEnd();
                    break;
            }
        }

        
    }
}
