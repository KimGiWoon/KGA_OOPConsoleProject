using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject.Player
{
    public class Player
    {
        public Vector2 playerPosition;
        

        private string playerClass; // Player Class
        public string PlayerClass { get { return playerClass; } set { playerClass = value; } }
        private int hp;     // Player HP
        public int Hp { get { return hp; } set { hp = value; } }
        private float str;  // Player Strhgth
        public float Str { get { return str; } set { str = value; } }
        private float dex;  // Player Dex     
        public float Dex { get { return dex; } set { dex = value; } }
        private float _int; // Player Int
        public float Int { get { return _int; } set { _int = value; } }
        private int luck;   // Player Luck
        public int Luck { get { return luck; } set { luck = value; } }

    }
    // TODO : 클래스 세팅 미구현
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
