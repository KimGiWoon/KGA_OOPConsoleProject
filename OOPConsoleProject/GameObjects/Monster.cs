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
        public int Hp { get { return hp; } set { hp = value; } }
        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }

       
        public Monster(string name, int hp, int damage, Vecter2 position, SceneType scene, bool disposable) : base(ConsoleColor.DarkRed,'◎', position, disposable)
        {
            this.Name = name;
            this.Hp = hp;
            this.Damage = damage;
            this.scene = scene;
            disposable = false;
        }

        public override void Interact(Player player)
        {
            GameManager.SceneChange(scene);
        }

        public void PlayerAttack(Player player)
        {
            Console.WriteLine("플레이어를 공격합니다.");
            Console.WriteLine("몬스터 : 쿠악!");
            Console.WriteLine("----------------------");
            player.PlayerTakeDamage(Damage);
        }

        public void MonsterTakeDamage(int damage)
        {
            Console.WriteLine("몬스터가 맞았습니다.");
            Hp -= damage;
            if (Hp < 0)
            {
                Hp = 0;
            }
            Console.WriteLine("커허헉.... 몬스터가 {0}의 데미지를 받았습니다 (몬스터의 남은 HP : {1})",damage, Hp);

        }

        public bool IsAlive()
        {
            return Hp > 0;
        }
    }
}
