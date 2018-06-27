using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典43
{
    //    【程序43】   
    //题目：求0—7所能组成的奇数个数。   
    ////组成1位数是4个。
    ////组成2位数是7*4个。
    ////组成3位数是7*8*4个。
    ////组成4位数是7*8*8*4个。
    ////......
    //public class lianxi43
    //    {
    //        public static void main(String[] args)
    //        {
    //            int sum = 4;
    //            int j;
    //            System.out.println("组成1位数是 " + sum + " 个");
    //            sum = sum * 7;
    //            System.out.println("组成2位数是 " + sum + " 个");
    //            for (j = 3; j <= 9; j++)
    //            {
    //                sum = sum * 8;
    //                System.out.println("组成" + j + "位数是 " + sum + " 个");
    //            }
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            int m = ShuRu("请输入一个1-9之间的数字m");
            int n = ShuRu("组成奇数最大位数n");
            int sum = 1;
            for (int j = 1; j <= n; j++)
            {
                sum = sum * (j == 1 ? (m+1)/2 : j == 2 ? m : (m + 1));
                Console.WriteLine($"0-{m}间的数字能组成的{j}位数奇数有{sum}个");
            }
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

