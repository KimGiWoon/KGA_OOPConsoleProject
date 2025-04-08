using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public struct Vecter2
    {
        public int x;   // x축 이동
        public int y;   // y축 이동

        public Vecter2(int x, int y)    // 생성자로 초기화
        {
            this.x = x;
            this.y = y;
        }
        
        // 백터와 백터의 위치가 같다는 것을 정의
        public static bool operator == (Vecter2 left, Vecter2 right)
        {
            return left.x == right.x && left.y == right.y;
        }
        // 백터와 백터의 위치가 같지 않다는 것을 정의
        public static bool operator != (Vecter2 left, Vecter2 right)
        {
            return left.x != right.x && left.y != right.y;
        }
       
        
    }
}
