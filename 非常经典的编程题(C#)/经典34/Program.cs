using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 经典34
{
//    【程序34】   
//题目：输入3个数a,b,c，按大小顺序输出。   
//import java.util.Scanner;
//    public class lianxi34
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            System.out.println("请输入3个整数：");
//            int a = s.nextInt();
//            int b = s.nextInt();
//            int c = s.nextInt();
//            if (a < b)
//            {
//                int t = a;
//                a = b;
//                b = t;
//            }
//            if (a < c)
//            {
//                int t = a;
//                a = c;
//                c = t;
//            }
//            if (b < c)
//            {
//                int t = b;
//                b = c;
//                c = t;
//            }
//            System.out.println("从大到小的顺序输出:");
//            System.out.println(a + " " + b + " " + c);
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Write("请输入第一个数字a=");
            x = Convert.ToInt32(ReadLine());
            Write("请输入第一个数字b=");
            y = Convert.ToInt32(ReadLine());
            Write("请输入第一个数字c=");
            z = Convert.ToInt32(ReadLine());
            int a = x;
            int b = z;
            x = (x <= y && x <= z) ? x : ((y <= z) ? y : z);
            z = (z >= y && z >= a) ? z : ((y >= a) ? y : a);
            y = (y < z && y > x) ? y : (y == x ? ((a >= b) ? b : a) : ((a >= b) ? a : b));
            WriteLine($"x,y,z从小到大排列为：{x}<={y}<={z}");
            ReadLine();
        }
    }
}
