using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public enum SceneType
    {//타이틀,  직업선택  ,  방   ,  마을  , 상점, 필드 ,   던전 ,  보스방 ,  전투     
        Title, ClassChoice, MyRoom, Village, Shop, Field, Dungeon, BossRoom, Battle
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
        //public virtual void Open() { }  // Open Interaction
        //public virtual void Close() { } // Close Interaction


    }
}
