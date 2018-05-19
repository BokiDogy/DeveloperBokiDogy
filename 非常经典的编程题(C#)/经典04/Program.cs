using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典04
{
//    【程序4】   
//题目：将一个正整数分解质因数。例如：输入90,打印出90=2*3*3*5。   
//程序分析：对n进行分解质因数，应先找到一个最小的质数k，然后按下述步骤完成：   
//(1)如果这个质数恰等于n，则说明分解质因数的过程已经结束，打印出即可。   
//(2)如果n<> k，但n能被k整除，则应打印出k的值，并用n除以k的商,作为新的正整数你n,重复执行第一步。   
//(3)如果n不能被k整除，则用k+1作为k的值,重复执行第一步。  
//import java.util.*;
//    public class lianxi04
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            System.out.print("请键入一个正整数:     ");
//            int n = s.nextInt();
//            int k = 2;
//            System.out.print(n + "=");
//            while (k <= n)
//            {
//                if (k == n) { System.out.println(n); break; }
//                else if (n % k == 0) { System.out.print(k + "*"); n = n / k; }
//                else k++;
//            }
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int number = ShuRu("一个任意正整数n");
            int num = number;
            if (number == 1)
            {
                Console.WriteLine($"您输入的数字{number}的分解质因数为:{number}={number}");
            }
            else
            {
                Console.Write($"您输入的数字{number}的分解质因数为:{number}=");
                for (int i = 1; i <= num/2; i++)
                {
                    for (count = 2; count <= number && (number % count) != 0; count++)
                    {
                    }
                    if (count == number)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"{count}*");
                        number = number / count;
                    }
                }
            }
            Console.WriteLine($"{number}");
            Console.ReadLine();
        }
        /// <summary>
        /// 输入函数
        /// </summary>
        /// <param name="des">屏幕提示</param>
        /// <returns>输入的x值</returns>
        public static int ShuRu(string des)
        {
            int x;
            Console.Write($"请输入{des}=");
            return x = Convert.ToInt32(Console.ReadLine());
        }
    }
}
