using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典10
{
//    【程序10】   
//题目：一球从100米高度自由落下，每次落地后反跳回原高度的一半；再落下，求它在 第10次落地时，共经过多少米？第10次反弹多高？ 
//public class lianxi10
//    {
//        public static void main(String[] args)
//        {
//            double h = 100, s = 100;
//            for (int i = 1; i < 10; i++)
//            {
//                s = s + h;
//                h = h / 2;
//            }
//            System.out.println("经过路程：" + s);
//            System.out.println("反弹高度：" + h / 2);
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            float h = 100, s = 100;
            int n = ShuRu("反弹次数n");
            for (int i = 1; i <= n ; i++)
            {
                s += h;
                h = h / 2;
            }
            Console.WriteLine($"第10次落地时共经过{s-2*h}米\n第10次反弹时高度为{h}米");
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
