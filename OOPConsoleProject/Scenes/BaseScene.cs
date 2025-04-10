using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public enum SceneType
    {//타이틀,  직업선택  ,  방   ,방 나레이션,  마을  , 마을 나레이션, 상점, 필드 ,   던전 ,  전투 , 게임오버, 게임클리어     
        Title, ClassChoice, MyRoom, RoomDialog, Village, villageDialog, Shop, Field, Dungeon, Battle, GameOver, GameClear
    }
    
    public abstract class BaseScene
    {
        public SceneType mapName;     // Map Name;
        public ConsoleKey keyDown;

        public abstract void Render();  // Situation
        public abstract void Input();   // Input
        public abstract void Update();  // Update
        public abstract void Result();  // Result

        public virtual void Enter() { } // Enter Interaction
        public virtual void Exit() { }  // Exit Interaction
        


    }
}
