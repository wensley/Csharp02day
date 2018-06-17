using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05交换两个变量的值
{
    class Program
    {
        static void Main(string[] args)
        {
            //第5题
            int a = 10;
            int b = 5;
            int temp;
            //这样写并没有交换变量的值，是错误的！
            //Console.WriteLine("a={0},b={1}",b,a); 
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a={0}  b={1}",a,b);
            Console.ReadKey();

        }
    }
}
