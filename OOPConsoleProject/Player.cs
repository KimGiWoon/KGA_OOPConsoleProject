using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Player
    {
        public Inventory inventory;
        public Vecter2 position;
        public bool[,] map;

        // 플레이어 스탯 프로퍼티 생성
        private string playerClass; // Player Class
        public string PlayerClass { get { return playerClass; } set { playerClass = value; } }
        private int maxHp;   // Player Max Hp
        public int MaxHp { get { return maxHp; } }
        private int hp;     // Player HP
        public int Hp { get { return hp; } set { hp = value; } }
        private float str;  // Player Strhgth
        public float Str { get { return str; } set { str = value; } }
        private float dex;  // Player Dex     
        public float Dex { get { return dex; } set { dex = value; } }
        private float _int; // Player Int
        public float Int { get { return _int; } set { _int = value; } }

        public Player()
        {
            inventory = new Inventory();

            PlayerClass = "모험가";
            Hp = 100;
            maxHp = hp;
            Str = 2;
            Dex = 2;
            Int = 1;        
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('▼');
            Console.ResetColor();
        }       

        public void HealLimit(int healAmount)
        {
            Hp += healAmount;
            if (hp > maxHp)
            {
                Hp = maxHp;
            }
        }

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
            Console.WriteLine("====Player Status====");
            Console.WriteLine("  {0}",PlayerClass.ToString());
            Console.WriteLine("체력 : {0}", Hp);
            Console.WriteLine("  힘 : {0}", Str);
            Console.WriteLine("지력 : {0}", Int);
            Console.WriteLine("민첩 : {0}", Dex);    
            Console.WriteLine("=====================");
        }

    }
    //TODO : 클래스 세팅 미구현
    //public class PlayerBuider
    //{
    //    public string PlayerClass;
    //    public int Hp;
    //    public float Str;
    //    public float Dex;
    //    public float Int;
    //    public int Luck;

    //    public PlayerBuider()
    //    {
    //        PlayerClass = "모험가";
    //        Hp = 50;
    //        Str = 1;
    //        Dex = 1;
    //        Int = 1;
    //        Luck = 1;
    //    }



    //    public Player Build()
    //    {
    //        Player player = new Player();
    //        player.PlayerClass = PlayerClass;
    //        player.Hp = Hp;
    //        player.Str = Str;
    //        player.Dex = Dex;
    //        player.Int = Int;
    //        player.Luck = Luck;
    //        return player;
    //    }

    //    public PlayerBuider SetClass(string _class)
    //    {
    //        this.PlayerClass = _class;
    //        return this;
    //    }
    //    public PlayerBuider SetHp(int hp)
    //    {
    //        this.Hp = hp;
    //        return this;
    //    }
    //    public PlayerBuider SetStr(float str)
    //    {
    //        this.Str = str;
    //        return this;
    //    }
    //    public PlayerBuider SetDex(float dex)
    //    {
    //        this.Dex = dex;
    //        return this;
    //    }
    //    public PlayerBuider SetInt(float _int)
    //    {
    //        this.Int = _int;
    //        return this;
    //    }
    //    public PlayerBuider SetLuck(int luck)
    //    {
    //        this.Luck = luck;
    //        return this;
    //    }
    //}
}

