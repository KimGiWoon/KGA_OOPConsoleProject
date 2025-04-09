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
        public static SceneType beforeScene;   // 이전 씬 이름

        private static Player player;   // 플레이어 프로퍼티 생성
        public static Player Player { get { return player; } }
       
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
            sceneList.Add(SceneType.Dungeon, new DungeonScene());
            sceneList.Add(SceneType.RoomDialog, new RoomDialog());
            sceneList.Add(SceneType.villageDialog, new VillageDialog());
            sceneList.Add(SceneType.Battle, new BattleScene());

            curScene = sceneList[SceneType.Title];
            
        }

        public static void SceneChange(SceneType scene)
        {
            beforeScene = curScene.mapName; // 이전 맵 저장

            curScene.Exit();
            curScene = sceneList[scene];
            curScene.Enter();
        }

        public static void GameEnd()
        {
            Console.Clear();
            Console.WriteLine("게임종료 합니다.");
            gameOver = true;
        }

    }
    
}
