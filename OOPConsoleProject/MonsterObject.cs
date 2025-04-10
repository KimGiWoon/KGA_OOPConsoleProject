using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject
{
    public abstract class MonsterObject : IInteraction
    {
        public Vecter2 position;
        public char shape;
        public ConsoleColor color;
        public bool disposable;
        private SceneType scene;

        public MonsterObject(ConsoleColor color, char shape, Vecter2 position, bool disposable)
        {
            this.color = color;
            this.shape = shape;
            this.position = position;
            this.disposable = disposable;
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(shape);
            Console.ResetColor();
        }


        public abstract void Interact(Player player);
        
    }
}
