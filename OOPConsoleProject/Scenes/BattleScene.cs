using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OOPConsoleProject.GameObjects;
using static System.Net.Mime.MediaTypeNames;

namespace OOPConsoleProject.Scenes
{
    public enum Choice
    {
        Menu, fight, Run, hit
    }
    public class BattleScene : BaseScene
    {
        Monster monster;
        Player player;
        Queue<Choice> monsterQueue;
        bool win = false;

        public BattleScene()
        {
            player = new Player();
            //monster = new Monster("");
            mapName = SceneType.Battle;
            monsterQueue = new Queue<Choice>();
        }
       
        public override void Render()
        {
            Console.WriteLine("몬스터가 싸움을 걸어옵니다");
            Console.WriteLine();
            Console.WriteLine("1. 싸운다");
            Console.WriteLine("2. 도망친다");
        }

        public override void Input()
        {
            keyDown = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            switch (keyDown)
            {
                case ConsoleKey.D1:
                    monsterQueue.Enqueue(Choice.Menu);
                    while (win == false)
                    {
                        Console.Clear();
                        switch (monsterQueue.Peek())
                        {
                            case Choice.Menu:
                                Menu();
                                break;
                            case Choice.fight:
                                fight();
                                break;
                            case Choice.Run:
                                Run();
                                break;
                            case Choice.hit:
                                hit();
                                break;
                            default:
                                Console.WriteLine("선택 범위를 벗어났습니다. 다시 입력해주세요");
                                return;

                        }
                    }
                    break;

            }
        }
            

        public void Menu()
        {
            Console.Clear();
            Utility.PressAnyKey("싸움을 준비합니다.");
            Console.WriteLine();
            Console.WriteLine("1. 공격!!");
            Console.WriteLine("2. 지금이라도 늦지않았어!! 도망치자");

            keyDown = Console.ReadKey(true).Key;
            switch (keyDown)
            {
                case ConsoleKey.D1:
                    monsterQueue.Dequeue();
                    monsterQueue.Enqueue(Choice.fight);
                    break;
                case ConsoleKey.D2:
                    monsterQueue.Dequeue();
                    monsterQueue.Enqueue(Choice.Run);
                    break;
            }
        }

        public void fight()
        {
            Console.WriteLine("몬스터를 공격합니다.");
            Console.WriteLine("플레이어 : 이야아압~!");
            monster.MonsterTakeDamage(player.Damage);
            Console.WriteLine("1. 다음");
            
            keyDown = Console.ReadKey(true).Key;
            switch (keyDown)
            {
                case ConsoleKey.D1:
                    monsterQueue.Dequeue();
                    monsterQueue.Enqueue(Choice.hit);
                    break;
            }
            
        }
        public void hit()
        {
            Console.WriteLine("몬스터가 플레이어를 공격합니다.");
            Console.WriteLine("몬스터 : 쿠악!");
            Console.WriteLine("1. 다음");

            keyDown = Console.ReadKey(true).Key;
            switch (keyDown)
            {
                case ConsoleKey.D1:
                    monsterQueue.Dequeue();
                    monsterQueue.Enqueue(Choice.Menu);
                    break;
            }
        }

        public void Run()
        {
            Utility.PressAnyKey("플레이어가 도망쳤습니다.");
            if (GameManager.beforeScene == SceneType.Field)
            {
                GameManager.SceneChange(SceneType.Field);
            }
            else
            {
                GameManager.SceneChange(SceneType.Dungeon);
            }
            monsterQueue.Dequeue();
        }

        public override void Result()
        {
            switch(keyDown)
            {
                

                case ConsoleKey.D2:
                    Utility.PressAnyKey("플레이어가 도망쳤습니다.");
                    if(GameManager.beforeScene == SceneType.Field)
                    {
                        GameManager.SceneChange(SceneType.Field);
                        break;
                    }
                    else 
                    {
                        GameManager.SceneChange(SceneType.Dungeon);
                        break;
                    }
                    
            }
        }

    }
}
