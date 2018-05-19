using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典25
{
    //    【程序25】   
    //题目：一个5位数，判断它是不是回文数。即12321是回文数，个位与万位相同，十位与千位相同。   
    //import java.util.*;
    //    public class lianxi25
    //    {
    //        public static void main(String[] args)
    //        {
    //            Scanner s = new Scanner(System.in);
    //            int a;
    //            do
    //            {
    //                System.out.print("请输入一个5位正整数：");
    //                a = s.nextInt();
    //            } while (a < 10000 || a > 99999);
    //            String ss = String.valueOf(a);
    //            char[] ch = ss.toCharArray();
    //            if (ch[0] == ch[4] && ch[1] == ch[3])
    //            {
    //                System.out.println("这是一个回文数");
    //            }
    //            else { System.out.println("这不是一个回文数"); }
    //        }
    //    }
    //    //这个更好，不限位数
    //    import java.util.*;
    //    public class lianxi25a
    //    {
    //        public static void main(String[] args)
    //        {
    //            Scanner s = new Scanner(System.in);
    //            boolean is = true;
    //            System.out.print("请输入一个正整数：");
    //            long a = s.nextLong();
    //            String ss = Long.toString(a);
    //            char[] ch = ss.toCharArray();
    //            int j = ch.length;
    //            for (int i = 0; i < j / 2; i++)
    //            {
    //                if (ch[i] != ch[j - i - 1]) {is= false; }
    //            }
    //            if (is== true) { System.out.println("这是一个回文数"); }
    //            else { System.out.println("这不是一个回文数"); }
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            long n;
            int m = 0, w = 1;
            bool isHuiwen = true;
            Console.Write("请输入一个正整数：");
            n = Convert.ToInt64(Console.ReadLine());
            while (n / w != 0)
            {
                w *= 10;
                m++;
            }
            for (int j = m; j >= (m + 1) / 2; j--)
            {
                int x = 1, y = 1;
                for (int i = 1; i <= j - 1; i++)
                {
                    x *= 10;
                }
                for (int i = 1; i <= m - j; i++)
                {
                    y *= 10;
                }
                if (n / x % 10 != n / y % 10)
                {
                    isHuiwen = false;
                    break;
                }
            }
            string result = isHuiwen ? "是" : "不是";
            Console.WriteLine($"您输入的数字{n}{result}回文数。");
            Console.ReadLine();
        }
    }
}
