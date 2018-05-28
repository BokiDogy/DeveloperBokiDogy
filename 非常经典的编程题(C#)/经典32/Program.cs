using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典32
{
//    【程序32】   
//题目：取一个整数a从右端开始的4～7位。   
//import java.util.*;
//    public class lianxi32
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            System.out.print("请输入一个7位以上的正整数：");
//            long a = s.nextLong();
//            String ss = Long.toString(a);
//            char[] ch = ss.toCharArray();
//            int j = ch.length;
//            if (j < 7) { System.out.println("输入错误！"); }
//            else
//            {
//                System.out.println("截取从右端开始的4～7位是：" + ch[j - 7] + ch[j - 6] + ch[j - 5] + ch[j - 4]);
//            }
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个7位以上的正整数：");
            char [] n  = Console.ReadLine().ToCharArray();
            if(n.Length<7)
            {
                Console.WriteLine("输入不正确，请输入一个7位以上的正整数：");
                char[] m = Console.ReadLine().ToCharArray();
                Console.WriteLine($"您输入的右端开始4-7位为：{m[m.Length - 7]},{m[m.Length - 6]},{m[m.Length - 5]},{m[m.Length - 4]}");
            }
            else
            {
                Console.WriteLine($"您输入的数字端开始4-7位为：{n[n.Length - 7]},{n[n.Length - 6]},{n[n.Length - 5]},{n[n.Length - 4]}");
            }
            Console.ReadLine();
        }
    }
}
