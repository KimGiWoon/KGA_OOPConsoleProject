using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPConsoleProject.Scenes
{
    public class BattleScene : BaseScene
    {
        public BattleScene()
        {
            mapName = SceneType.Battle;
        }

        public override void Input()
        {
            Utility.SlowTextPrint("시끌~~! 시끌~~!");
        }

        public override void Render()
        {
            throw new NotImplementedException();
        }

        public override void Result()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
