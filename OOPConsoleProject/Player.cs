using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject
{
    
    public class Player
    {
        private Inventory inventory;    // Player Inventory
        public Inventory Inventory { get { return inventory; } }
        public Vecter2 position;
        public bool[,] map;
        Random random = new Random();
        
        // 플레이어 스탯 프로퍼티 생성
        private string playerClass; // Player Class
        public string PlayerClass { get { return playerClass; } set { playerClass = value; } }
        private int maxHp;   // Player Max Hp
        public int MaxHp { get { return maxHp; } }
        private int hp;     // Player HP
        public int Hp { get { return hp; } set { hp = value; } }
        private int damage;  // Player Damage
        public int Damage { get { return damage; } set { damage = value; } }
        private int defence;  // Player Defence     
        public int Defence { get { return defence; } set { defence = value; } }
        private int evasion; // Player Evasion
        public int Evasion { get { return evasion; } set { evasion = value; } }
        private int luck;   // Player Luck
        public int Luck { get { return luck; } set { luck = value; } }

        private string monsterName;
        public string MonsterName { get { return monsterName; } set { monsterName = value; } }

        public Player()
        {
            inventory = new Inventory();
            Luck = random.Next(1, 11);

            PlayerClass = "모험가";
            Hp = 100;
            maxHp = Hp;
            Damage = 30;
            Defence = 5;
            Evasion = 5;
        }

        public void InterractMonster(Monster monster)
        {
            MonsterName = monster.Name;
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('▼');
            Console.ResetColor();
        }       

        public void Heal(int healAmount)
        {
            Hp += healAmount;
            if (hp > maxHp) // 힐링량 Limit Setting
            {
                Hp = maxHp;
            }
        }
        // Player Action
        public void playerAction(ConsoleKey keyDown)
        {
            switch(keyDown)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                    Move(keyDown);
                    break;
                case ConsoleKey.I:
                    Inventory.Open();
                    break;
            }
        }
        // Player Move
        public void Move(ConsoleKey keyDown)
        {
            Vecter2 MovePos = position;

            switch (keyDown)
            {
                case ConsoleKey.UpArrow:
                    MovePos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    MovePos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    MovePos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    MovePos.x++;
                    break;
            }

            if (map[MovePos.y, MovePos.x] == true)
            {
                position = MovePos;
            }
        }
        public void StatusPint()
        {
            Console.WriteLine("┏━━━━━━ 스 탯 ━━━━━━┓");
            Console.WriteLine(" 직업 : {0}",PlayerClass);
            Console.WriteLine(" 체력 : {0}", Hp);
            Console.WriteLine(" 데미지 : {0}", Damage);
            Console.WriteLine(" 방어력 : {0}", Defence);
            Console.WriteLine(" 회피력 : {0}", Evasion);    
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━┛");
        }

        public void MonsterAttack(Monster monster)
        {
            Console.WriteLine("몬스터를 공격합니다.");
            Console.WriteLine("플레이어 : 이야아압~!");
            monster.MonsterTakeDamage(Damage);
        }

        public void PlayerTakeDamage(int damage)
        {
            Console.WriteLine("플레이어가 맞았습니다.");
            int totalDamage = Defence > damage ? 0 : damage - Defence;
            Hp -= totalDamage;
            if(Hp < 0)
            {
                Hp = 0;
            }
            Console.WriteLine("으아아악!! {0}의 데미지를 받았습니다 (플레이어의 남은 HP : {1}",totalDamage, Hp);
        }

        public bool IsAlive()
        {
            return Hp > 0;
        }
        
    }

}

