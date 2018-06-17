using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07转义字符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#中的字符要用\"\"引起来。");  //转义字符是一个字符，他由一个\+一个字母来组成具有特殊意义的一个字符。
            Console.WriteLine("C#中的字符要用\n\"\"引起来。"); //\n ：换行
            Console.WriteLine("C#中的\b字符要用\"\"引起来。");//\b退格，的字会被删除，不予显示；
            Console.WriteLine("1\t2\t3\t4\t5");// \t 具有行与行之间的对齐功能
            Console.WriteLine("11\t111\t1234\t7");
            Console.WriteLine(@"E:\学习\传智播客""c#基础视频教程(第一季)""");  //如果字符串前面家里 @符号，在字符串上用两个双引号代表一个双引号；
            Console.ReadKey();
        }
    }
}
