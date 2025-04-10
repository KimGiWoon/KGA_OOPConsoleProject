using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject.GameObjects
{
    public class Monster : GameObject
    {
        private SceneType scene;

        private string name;
        public string Name { get { return name; } set { name = value; } }
        private int hp;
        public int HP { get { return hp; } set { hp = value; } }
        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }

       
        public Monster(string name, int hp, int damage, Vecter2 position, SceneType scene) : base(ConsoleColor.DarkRed,'◎', position, true)
        {
            this.Name = name;
            this.HP = hp;
            this.Damage = damage;
            this.scene = scene;

            //MonsterFactory stage_1_Monster = new MonsterFactory();
            //MonsterFactory stage_2_Monster = new MonsterFactory();
            //MonsterFactory boss_Monster = new MonsterFactory();
            //stage_1_Monster.stageLevel = 1;
            //stage_2_Monster.stageLevel = 2;

            //// 필드 몬스터 생성
            //Monster monster1 = stage_1_Monster.Create("버섯병사");
            //Monster monster2 = stage_1_Monster.Create("버섯쫄병");
            //Monster monster3 = stage_1_Monster.Create("버섯기사");

            //// 던전 몬스터, 보스 몬스터 생성
            //Monster monster4 = stage_2_Monster.Create("버섯기사");
            //Monster monster5 = stage_2_Monster.Create("버섯장군");
            //Monster bossMonster = boss_Monster.Create("버섯킹");

        }

        public override void Interact(Player player)
        {
            GameManager.SceneChange(scene);
        }

        public void PlayerAttack(Player player)
        {
            Console.WriteLine("플레이어를 공격합니다.");
            Console.WriteLine("몬스터 : 쿠악!");
            player.PlayerTakeDamage(Damage);
        }

        public void MonsterTakeDamage(int damage)
        {
            Console.WriteLine("몬스터가 맞았습니다.");
            HP -= damage;
            Console.WriteLine("커허헉.... {0}의 데미지를 받았습니다 ( 남은 HP : {1}",damage, HP);

        }

        public bool IsAlive()
        {
            return HP > 0;
        }
    }
   
        
    
    //public class MonsterFactory
    //{
    //    public int stageLevel;
    //    public float rate;

    //    public Monster Create(string name)
    //    {
    //        Monster monster;

    //        switch (name)
    //        {
    //            case "버섯병사": monster = new Monster("버섯병사", 50, 2 + stageLevel, new Vecter2(0, 0), SceneType.Battle); break;
    //            case "버섯쫄병": monster = new Monster("버섯쫄병", 40, 2 + stageLevel, new Vecter2(0, 0), SceneType.Battle); break;
    //            case "버섯기사": monster = new Monster("버섯기사", 70, 3 + stageLevel, new Vecter2(0, 0), SceneType.Battle); break;
    //            case "버섯장군": monster = new Monster("버섯장군", 100, 4 + stageLevel, new Vecter2(0, 0), SceneType.Battle); break;
    //            case "버섯킹": monster = new Monster("버섯킹", 200, 5 + stageLevel, new Vecter2(0, 0), SceneType.Battle); break;
    //            default: return null;
    //        }
    //        return monster;

    //    }
    //}
}
