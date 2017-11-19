using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            if (String.Compare(s, Console.ReadLine()) == 0)
            {
                Console.WriteLine("字串" + s.Substring(3));
                Console.WriteLine("删除" + s.Remove(0,2));
            }
        }
    }
}
