using System;

namespace 测试项目
{
    class Program
    {
        static void Main(string[] args)
        {
            //在控制台打印出 你好世界这个内容
            //在控制台 打印一行信息 打印信息结束后 自动空一行
            Console.WriteLine("Hello, World!");
            //双引号之间的内容，对于符号没有特别的要求
            //在控制台打印信息 但是打印完成后 不会自动空行
            Console.Write("你好，我喜欢你");
            Console.Write("我要好好学习，天天向上");

            //检测玩家输入的代码
            //等待玩家输入完毕后（按回车键）
            //玩家可以输入 很多信息 直到回车结束
            Console.ReadLine();
            Console.WriteLine("玩家输入完毕");

            //检测玩家是否按键 只要按了键盘上的任意键 就会输入结束
            Console.ReadKey();


            Console.WriteLine("玩家输入完毕");

            //输入 在控制台输入内容
            //Console.ReadLine();
            //Console.ReadKey();

            //输出 在控制台打印信息
            //Console.WritrLine("XXXXXXX");
            //Console.Write("XXXXXXX");

        }
    }
}
