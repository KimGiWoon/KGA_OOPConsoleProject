using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public static class Utility
    {
        public static void TextPrint(string text, ConsoleColor textColor = ConsoleColor.White, int delay = 100)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(text);
            Thread.Sleep(delay);
            Console.ResetColor();
        }
        public static void SlowTextPrint(string text, ConsoleColor textColor = ConsoleColor.White, int delay = 30)
        {
            text.Split(" ");
            Console.ForegroundColor = textColor;
            foreach (char textSplit in text)
            {
                Console.Write(textSplit);
                Thread.Sleep(delay);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        public static void PressAnyKey(string text)     // 아무키나 누르는 동작 함수
        {
            Console.WriteLine(text);
            Console.WriteLine("계속하려면 아무키나 누르세요.");
            Console.ReadKey();
        }
    }

    
}
