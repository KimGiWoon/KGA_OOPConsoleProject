using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public static class Utility
    {

    }

    public static class TextUtil
    {
        public static void PressAnyKey(string text)     // 아무키나 누르는 동작 함수
        {
            Console.WriteLine(text);
            Console.WriteLine("계속하려면 아무키나 누르세요.");
            Console.ReadKey();
        }
    }
}
