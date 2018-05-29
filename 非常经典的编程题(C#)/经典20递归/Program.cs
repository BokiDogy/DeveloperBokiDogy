using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典20递归
{
    class Program
    {
        static void Main(string[] args)
        {
            int m=ShuRu("所求项数m");
            double sum = 0;
            for(int i=1;i<=m;i++)
            {
                //sum += Fblqw(i+2, 1, 0)*1.0d/Fblqw(i+1,1,0);
                sum += Fblq(i + 2) * 1.0d / Fblq(i + 1);
            }
            Console.WriteLine($"前{m}项的和为：{sum}");
            Console.ReadLine();
        }
        /// <summary>
        /// 求斐波拉契数列第n项(尾递归)
        /// </summary>
        /// <param name="n">输入n</param>
        /// <returns>返回斐波拉契数列第n项</returns>
        public static int Fblqw(int n, int res1, int res2)
        {
            if (n == 1)
            {
                return res1;
            }
            else
            {
                return Fblqw(n - 1, res1 + res2, res1);
            }
        }
        /// <summary>
        /// 求斐波拉契数列第n项
        /// </summary>
        /// <param name="n">输入n</param>
        /// <returns>返回斐波拉契数列第n项</returns>
        public static int Fblq(int n)
        {
            if (n==1||n==2)
            {
                return 1;
            }
           else
            {
                return Fblq(n - 1)+Fblq(n-2);
            }
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
