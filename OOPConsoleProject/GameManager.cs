using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject
{
    public static class GameManager
    {
        private static Dictionary<SceneType, BaseScene> sceneList;
        private static BaseScene curScene;

        private static Player player;   // 플레이어 프로퍼티 생성
        public static Player Player { get { return player; } }

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
            player = new Player();     //플레이어 설정

            sceneList = new Dictionary<SceneType, BaseScene>();
            sceneList.Add(SceneType.Title, new TitleScene());
            sceneList.Add(SceneType.ClassChoice, new ClassChoiceScene());
            sceneList.Add(SceneType.MyRoom, new MyRoomScene());
            sceneList.Add(SceneType.Village, new VillageScene());
            sceneList.Add(SceneType.Field, new FieldScene());

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
