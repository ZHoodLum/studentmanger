using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 作业1
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            int i, j;  
            Random Rnd = new Random();  
            int k;  
            int[] Card = new int[52];  
            int[,] Player = new int[4, 13];  
            for (i = 0; i < 4; i++)  
            {  
                for (j = 0; j < 13; j++)  
                {  
                    Card[i * 13 + j] = (i + 1) * 100 + j + 1;  
                }  
            }  
            Console.Write("洗牌次数:");  
            string s = Console.ReadLine();  
            int times = Convert.ToInt32(s);  
            for (j = 1; j <= times; j++)  
            {  
                for (i = 0; i < 52; i++)  
                {  
                    k = Rnd.Next(51 - i + 1) + i;  
                    int temp = Card[i];  
                    Card[i] = Card[k];  
                    Card[k] = temp;  
                }  
            }  
            k = 0;  
            for (j = 0; j < 13; j++)  
            {  
                for (i = 0; i < 4; i++)  
                {  
                    Player[i, j] = Card[k++];  
                }  
            }  
            for (i = 0; i < 4; i++)  
            {  
                Console.WriteLine("玩家{0}:", i + 1);  
                for (j = 0; j < 13; j++)  
                {  
                    k = (int)Player[i, j] / 100;  
                    switch (k)  
                    {  
                        case 1:  
                            s = Convert.ToString("红桃");  
                            break;  
                        case 2:  
                            s = Convert.ToString("方片");  
                            break;  
                        case 3:  
                            s = Convert.ToString("梅花");  
                            break;  
                        case 4:  
                            s = Convert.ToString("黑桃");  
                            break;  
                    }  
                    k = Player[i, j] % 100;  
                    switch (k)  
                    {  
                        case 1:  
                            s = s + "A";  
                            break;  
                        case 11:  
                            s = s + "J";  
                            break;  
                        case 12:  
                            s = s + "Q";  
                            break;  
                        case 13:  
                            s = s + "K";  
                            break;  
                        default:  
                            s = s + Convert.ToString(k);  
                            break;  
                    }  
                    Console.Write(s);  
                    if (j < 12)  
                        Console.Write(", ");  
                    else  
                        Console.WriteLine(" ");  
                }  
            }  
            Console.Read();  
        }  
    }  
} 