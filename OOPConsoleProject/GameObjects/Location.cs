using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject.GameObjects
{
    public class Location : GameObject
    {
        private SceneType scene;

        public Location(char shape, ConsoleColor color, Vecter2 position, SceneType scene) : base(color, shape, position, false)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            GameManager.SceneChange(scene);
        }
    }
}
