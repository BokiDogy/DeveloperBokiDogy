using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典41
{
    //    【程序41】   
    //题目：海滩上有一堆桃子，五只猴子来分。第一只猴子把这堆桃子凭据分为五份，多了一个，这只猴子把多的一个扔入海中，拿走了一份。第二只猴子把剩下的桃子又平均分成五份，又多了一个，它同样把多的一个扔入海中，拿走了一份，第三、第四、第五只猴子都是这样做的，问海滩上原来最少有多少个桃子？   
    //public class lianxi41
    //    {
    //        public static void main(String[] args)
    //        {
    //            int i, m, j = 0, k, count;
    //            for (i = 4; i < 10000; i += 4)
    //            {
    //                count = 0;
    //                m = i;
    //                for (k = 0; k < 5; k++)
    //                {
    //                    j = i / 4 * 5 + 1;
    //                    i = j;
    //                    if (j % 4 == 0)
    //                        count++;
    //                    else break;
    //                }
    //                i = m;
    //                if (count == 4)
    //                {
    //                    System.out.println("原有桃子 " + j + " 个");
    //                    break;
    //                }
    //            }
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"第{i + 1}只猴子拥有的最少的桃子个数为：{GetPeachNum(5 - i)}");
            //}
            //Console.ReadLine();
            double sum=0;
            int startnum = 6,i=1;
            for(i = 1; i <= 4;i++)
            {
                if(i==1)
                {
                    sum = startnum;
                }
                sum = sum * 5.0d / 4 + 1;
                if (sum % 1.0d != 0)
                {
                    startnum += 5;
                    i = 0;
                }
            }
            Console.WriteLine($"{sum}");
            for(i=1;i<=5;i++)
            {
                Console.WriteLine($"第{i}只猴子的桃子数目为{sum}");
                sum = (sum - 1) * 4.0d / 5;
            }
            Console.ReadLine();
        }
        public static int GetPeachNum(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n > 0)
            {
                return GetPeachNum(n - 1) * 5 + 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
