using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;//命名空间

namespace 第一个控制台程序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入姓名");
            string s = Console.ReadLine();
            Console.WriteLine("欢迎你" + s);
            Console.ReadLine();//目的是让屏幕停住
        }
    }
}
/*
  * 1.输入
  *Console.ReadLine();   从标准的输入流读取下一行字符
  *Console.Read();      字符
  *Console.Readkey();   有功能键
  * 2.输出
  *Console.WriteLine();   后跟当前行终止符
  *Console.Write();   将指定的字符串值写入标准输出流
*/

