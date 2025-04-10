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
        Menu, fight, Run, hit, Win, Die
    }
    public class BattleScene : BaseScene
    {
        Monster monster;
        Player player;
        Queue<Choice> monsterQueue;
        bool battleEnd = false;

        public BattleScene()
        {
            player = new Player();
            monster = new Monster("버섯킹", 200, 20, new Vecter2(12, 2), SceneType.Battle, false);
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
            
        }
        public override void Result()
        {
            monsterQueue.Enqueue(Choice.Menu);
            switch (keyDown)
            {
                case ConsoleKey.D1:
                    while (monsterQueue.Count > 0)
                    {
                        while (battleEnd == false)
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
                                case Choice.Win:
                                    Win();
                                    battleEnd = true;
                                    break;
                                case Choice.Die:
                                    Die();
                                    battleEnd = true;
                                    break;
                                default:
                                    Console.WriteLine("선택 범위를 벗어났습니다. 다시 입력해주세요");
                                    return;

                            }
                        }
                    }
                    if (!(player.IsAlive()))
                    {
                        GameManager.SceneChange(SceneType.GameOver);
                    }
                    else if (GameManager.beforeScene == SceneType.Field)
                    {
                        GameManager.SceneChange(SceneType.Field);
                    }
                    else
                    {
                        GameManager.SceneChange(SceneType.Dungeon);
                    }
                    break;

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
            player.MonsterAttack(monster);
            Console.WriteLine();
            Console.WriteLine("1. 다음");

            keyDown = Console.ReadKey(true).Key;

            switch (keyDown)
            {
                case ConsoleKey.D1:
                    if (monster.IsAlive())
                    {
                        monsterQueue.Dequeue();
                        monsterQueue.Enqueue(Choice.hit);
                    }
                    else
                    {
                        monsterQueue.Dequeue();
                        monsterQueue.Enqueue(Choice.Win);
                    }
                    break;
            }

        }
        public void hit()
        {
            monster.PlayerAttack(player);
            Console.WriteLine();
            Console.WriteLine("1. 다음");

            keyDown = Console.ReadKey(true).Key;
            switch (keyDown)
            {
                case ConsoleKey.D1:
                    if (player.IsAlive())
                    {
                        monsterQueue.Dequeue();
                        monsterQueue.Enqueue(Choice.Menu);
                    }
                    else
                    {
                        monsterQueue.Dequeue();
                        monsterQueue.Enqueue(Choice.Die);
                    }
                    break;
            }
        }

        public void Run()
        {
            Utility.PressAnyKey("플레이어가 도망쳤습니다.");
            monsterQueue.Dequeue();
            if (GameManager.beforeScene == SceneType.Field)
            {
                GameManager.SceneChange(SceneType.Field);
            }
            else
            {
                GameManager.SceneChange(SceneType.Dungeon);
            }

        }

        public void Win()
        {

            Utility.PressAnyKey("축하합니다~! 몬스터가 죽었습니다.");
            monsterQueue.Dequeue();
        }

        public void Die()
        {
            Utility.PressAnyKey("플레이어가 죽었습니다.");
            monsterQueue.Dequeue();
        }

    }
}
