using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典01尾递归实现
{
    //    题目：古典问题：有一对兔子，从出生后第3个月起每个月都生一对兔子，小兔子长到第三个月后每个月又生一对兔子，假如兔子都不死，问每个月的兔子总数为多少？   
    ////这是一个菲波拉契数列问题
    //public class lianxi01 {
    //public static void main(String[] args) {
    //System.out.println("第1个月的兔子对数:    1");
    //System.out.println("第2个月的兔子对数:    1");
    //int f1 = 1, f2 = 1, f, M=24;
    //     for(int i=3; i<=M; i++) {
    //      f = f2;
    //      f2 = f1 + f2;
    //      f1 = f;
    //      System.out.println("第" + i +"个月的兔子对数: "+f2);
    //         }
    //}
    //}
    class Program
    {
        static void Main(string[] args)
        {
            int n = ShuRu("所求月份n");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"第{i}个月兔子对数为:{f(i,1,0)}");
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
        /// <summary>
        /// 递归实现求出第n项斐波那契数列值
        /// </summary>
        /// <param name="n">输入第n项</param>
        /// <returns>返回第n项斐波那契数列值</returns>
        public static int f(int n ,int res1,int res2)//尾递归,res1,res2记录递归每一步返回值，减少内存占用
        {
            if (n == 1)
            {
                return res1;
            }
            else
            {
                return f(n - 1,res1+res2, res1);
            }
        }
    }
}
