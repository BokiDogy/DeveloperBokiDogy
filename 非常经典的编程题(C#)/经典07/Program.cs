using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典07
{
    //    【程序7】   
    //题目：输入一行字符，分别统计出其中英文字母、空格、数字和其它字符的个数。   
    //import java.util.*;
    //    public class lianxi07
    //    {
    //        public static void main(String[] args)
    //        {
    //            int digital = 0;
    //            int character = 0;
    //            int other = 0;
    //            int blank = 0;
    //            char[] ch = null;
    //            Scanner sc = new Scanner(System.in);
    //            String s = sc.nextLine();
    //            ch = s.toCharArray();
    //            for (int i = 0; i < ch.length; i++)
    //            {
    //                if (ch >= '0' && ch <= '9')
    //                {
    //                    digital++;
    //                }
    //                else if ((ch >= 'a' && ch <= 'z') || ch > 'A' && ch <= 'Z')
    //                {
    //                    character++;
    //                }
    //                else if (ch == ' ')
    //                {
    //                    blank++;
    //                }
    //                else
    //                {
    //                    other++;
    //                }
    //            }
    //            System.out.println("数字个数: " + digital);
    //            System.out.println("英文字母个数: " + character);
    //            System.out.println("空格个数: " + blank);
    //            System.out.println("其他字符个数:" + other);
    //        }
    //   char[] tempChar = sourceString.ToCharArray();   }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串：");
            string input = Console.ReadLine();
            char[] zf = input.ToCharArray();
            char[] sz = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9','0' };
            char[] xxzm = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] dxzm = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'Y', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] kg = new char[] { ' ' };
            Console.WriteLine($"您输入的字符串中数字的个数为:{DuiBiJiShu(zf, sz)}");
            Console.WriteLine($"您输入的字符串中英文字母的个数为:{DuiBiJiShu(zf, dxzm) + DuiBiJiShu(zf, xxzm)}，小写字母个数为{DuiBiJiShu(zf, xxzm)},大写字母个数为{DuiBiJiShu(zf, dxzm)}");
            Console.WriteLine($"您输入的字符串中空格的个数为:{DuiBiJiShu(zf, kg)}");
            Console.WriteLine($"您输入的字符串中其他字符的个数为:{zf.Length - DuiBiJiShu(zf, sz) - DuiBiJiShu(zf, dxzm) - DuiBiJiShu(zf, xxzm) - DuiBiJiShu(zf, kg)}");
            Console.ReadLine();
        }
        /// <summary>
        /// 对比两个字符数组计数相同个数
        /// </summary>
        /// <param name="a">输入源数组a</param>
        /// <param name="b">输入字典数组b</param>
        /// <returns>返回个数n</returns>
        public static int DuiBiJiShu(char[] a, char[] b)
        {
            int n = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j] == a[i])
                    {
                        n++;
                        break;
                    }
                }
            }
            return n;
        }
    }
}
