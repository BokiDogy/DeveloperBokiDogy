using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典11修改
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入任一数字：");
            string n = Console.ReadLine();
            char[] a = n.ToCharArray();
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((int)a[i] < 48 || (int)a[i] > 57)
                {
                    Console.Write("您的输入无效，请重新输入：");
                    n = Console.ReadLine();
                    a = n.ToCharArray();
                    i = -1;
                }
            }
            for (int l = 0; l < a.Length; l++)
            {
                for (int j = l + 1; j < a.Length; j++)
                    {
                        if (a[j] == a[l])
                        {
                            a[j] = (char)0;
                        }
                    }
            }
            for (int x = 0; x < a.Length; x++)
            {
                if (a[x] != '0')
                {
                    for (int y = 0; y < a.Length; y++)
                    {
                        for (int z = 0; z < a.Length; z++)
                        {
                            if (a[x] != a[y] && a[y] != a[z] && a[x] != a[z] && (int)a[z] * (int)a[y] * (int)a[x] != 0)
                            {
                                count++;
                                Console.WriteLine($"第{count}个三位数为：{a[x]}{a[y]}{a[z]}");
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"共能组成{count}个三位数。");
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
        /// <summary>
        /// 求一个数字的位数
        /// </summary>
        /// <param name="n">输入一个数字n</param>
        /// <returns>返回位数i</returns>
        public static int WeiShu(int n)
        {
            int w = 1, i = 0;
            while (n / w != 0)
            {
                w *= 10;
                i++;
            }
            return i;
        }
        /// <summary>
        /// 将一个数字各位数字存入int数组
        /// </summary>
        /// <param name="n">输入一个数字n</param>
        /// <returns>返回数组a</returns>
        public static int[] SaveWeiShu(int n)
        {
            int w = 1, i = 0;
            int[] a = new int[WeiShu(n)];
            while (n / w != 0)
            {
                a[i] = n / w % 10;
                w *= 10;
                i++;
            }
            return a;
        }
    }
}