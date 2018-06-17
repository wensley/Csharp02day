using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09算术运算的习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习二
            //double R = 5;
            //int R = 5;  //为什么int乘double会得到double？？？
            //double PI = 3.14;
            //double S = R * R * PI;

            //Console.WriteLine("s={0}", S);
            ////练习三
            //double Txue = 35;
            //double kuzi = 120;
            //double sum = 3 * Txue + 2 * kuzi;
            //double zhe = sum * 0.88;
            //Console.WriteLine("购物总计：{0}元，折后应付：{1}元", sum, zhe);

            //演示
            int a = 10,b=3;
            int mod = a % b;
            double quo = a / b;
            Console.WriteLine(mod);
            Console.WriteLine(quo);
            

            Console.ReadKey();
        }
    }
}
