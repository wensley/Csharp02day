using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //string name = "张三";
            //char sex = '男';
            //int age = 18;
            //int number = 10;
            //number = number + 1;
            //Console.WriteLine(number);
            //string name = "张三";
            //Console.Write("你好，");
            //Console.Write(name);
            string name = "张三";
            int age = 28;
            double money = 7600.33;
            //Console.WriteLine("我叫"+name+",今年"+age+"岁了,我的工资是"+money+"元。");
            Console.WriteLine("我叫{0}，今年{1}岁了，我的工资是{2}元。",name,age,money);

            //int age = 18;
            //age = age + 2;
            //Console.WriteLine(age);
            Console.ReadKey();

        }
    }
}
