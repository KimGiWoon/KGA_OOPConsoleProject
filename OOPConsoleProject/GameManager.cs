using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.Player;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject
{
    public static class GameManager
    {
        private static Dictionary<SceneType, BaseScene> sceneList;
        private static BaseScene curScene;

        // TODO : 클래스 세팅 미구현
        //private static PlayerBuider player;
        //public static PlayerBuider Player { get { return player; } }

        private static bool gameOver;
        
        public static void GameRun()
        {
            GameStart();

            while(gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Result();
            }

            GameEnd();
        }

        public static void GameStart()
        {
            Console.CursorVisible = false;  // 커서 세팅
            gameOver = false;   // 게임 설정
            // TODO : 클래스 세팅 미구현
            // player = new PlayerBuider();     //플레이어 설정

            sceneList = new Dictionary<SceneType, BaseScene>();
            sceneList.Add(SceneType.Title, new TitleScene());

            curScene = sceneList[SceneType.Title];
        }

        public static void SceneChange(SceneType scene)
        {
            curScene.Exit();
            curScene = sceneList[scene];
            curScene.Enter();
        }

        public static void GameEnd()
        {

        }

    }
    
}
