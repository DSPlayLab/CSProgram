using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPlayCS
{
    class test
    {
        static void Main(string[] args)
        {
            int number;
            number = 7;
            int i = 8;
            Console.WriteLine("{0}", i);
            int a, b, c;
            a = 1;
            b = 2;
            c = 3;
            Console.WriteLine("{0},{1},{2}", a, b, c);
            const int MAX = 100;
            Console.WriteLine("최대값: {0}", MAX);
            Console.WriteLine("[32 비트] int 최솟값: {0}" ,int.MinValue);
            Console.WriteLine("[32 비트] int 최댓값: {0}", int.MaxValue);


            //Console.Write("줄 바꿈 없음");
            //Console.WriteLine("줄 바꿈 포함");
        }
    }
}
