using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的应用
{
    class Cat
    {
        private int age;
        private static int weight;

        
        private string color;

        public Cat()
        {
            Console.WriteLine("这是不带参数的构造函数");
        }
        public Cat(int a,int b)
        {
            age = a;
            weight=b;
        }
        //定义猫的颜色
        public string Color
        {
            get { return color;}
            set { color = value; }
        }
        //猫的体重
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        //猫的捕食方法
        public static void Eat()
        {
            weight++;
        }
        //猫的爬树方法
        public int Swarm()
        {
            return weight--;
        }

    }
}
