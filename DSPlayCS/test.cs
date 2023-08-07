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

            float f = 99.99F;
            Console.WriteLine("{0}", f);

            //@ 기호로 여러 줄 문자열 사용 -> 줄 바꿈, 빈 공백까지 문자열로 저장됨
            string multi = @"
                안녕하세요.
                반갑습니다.";
            Console.WriteLine(multi);

            //문자열 보간법에 사용되는 변수 값은 모두 문자열로 처리됨
            int num = 3;
            string result = "홀수";
            Console.WriteLine($"{num}은 {result}입니다.");

            //string.Format() 메서드로 문자열 묶기
            string msg = string.Format("{0}님, {1}", "백승수", "안녕하세요");
            Console.WriteLine(msg);

            string message = "string Interpolation";
            Console.WriteLine("Message : {0}", message); //매서드 기본 제공
            Console.WriteLine("Message :" + message); //더하기 연산자
            Console.WriteLine($"Message : {message}"); //문자열 보간법



            //Console.Write("줄 바꿈 없음");
            //Console.WriteLine("줄 바꿈 포함");
        }
    }
}
