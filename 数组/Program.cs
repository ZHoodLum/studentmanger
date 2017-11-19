using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)//a.length  数组长度   亦可以i<10
            {
                Console.WriteLine("请输入第" + (i + 1).ToString() + "数");
                a[i] = Convert.ToInt32( Console.ReadLine());//进行转换  cinvert.toint  整形
                
             }
            int max = a[0], min = a[0];
            foreach (int m in a)//foreach(类型 变量名 in 数组名)
            {
                if (max < m)
                    max = m;
                if (min > m)
                    min = m;
            }
            /*for(int i=1;i<10;i++)
            {
                if (max < a[i])
                    max = a[i];
                if (min > a[i])
                    min = a[i];
            }*/
            Console.WriteLine("最大值:" + max);
            Console.WriteLine("最小值:" + min);
            Console.ReadLine();

        } 
    }
}
