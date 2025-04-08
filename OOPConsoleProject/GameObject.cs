using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public abstract class GameObject : IInteraction
    {
        public Vecter2 position;
        public char shape;
        public ConsoleColor color;

        public GameObject(ConsoleColor color, char shape, Vecter2 position)
        {
            this.color = color;
            this.shape = shape;
            this.position = position;
        }

        public abstract void interact(Player player);
       

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(shape);
            Console.ResetColor();
        }


    }
}
