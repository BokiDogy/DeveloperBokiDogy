using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典26
{
    //    【程序26】   
    //题目：请输入星期几的第一个字母来判断一下是星期几，如果第一个字母一样，则继续 判断第二个字母。   
    //import java.util.*;
    //    public class lianxi26
    //    {
    //        public static void main(String[] args)
    //        {
    //            getChar tw = new getChar();
    //            System.out.println("请输入星期的第一个大写字母：");
    //            char ch = tw.getChar();
    //            switch (ch)
    //            {
    //                case 'M':
    //                    System.out.println("Monday");
    //                    break;
    //                case 'W':
    //                    System.out.println("Wednesday");
    //                    break;
    //                case 'F':
    //                    System.out.println("Friday");
    //                    break;
    //                case 'T':
    //                    {
    //                        System.out.println("请输入星期的第二个字母：");
    //                        char ch2 = tw.getChar();
    //                        if (ch2 == 'U') { System.out.println("Tuesday"); }
    //                        else if (ch2 == 'H') { System.out.println("Thursday"); }
    //                        else
    //                        {
    //                            System.out.println("无此写法！");
    //                        }
    //                    };
    //                    break;
    //                case 'S':
    //                    {
    //                        System.out.println("请输入星期的第二个字母：");
    //                        char ch2 = tw.getChar();
    //                        if (ch2 == 'U') { System.out.println("Sunday"); }
    //                        else if (ch2 == 'A') { System.out.println("Saturday"); }
    //                        else
    //                        {
    //                            System.out.println("无此写法！");
    //                        }
    //                    };
    //                    break;
    //                default: System.out.println("无此写法！");
    //            }
    //        }
    //    }

    //class getChar
    //{
    //    public char getChar()
    //    {
    //        Scanner s = new Scanner(System.in);
    //        String str = s.nextLine();
    //        char ch = str.charAt(0);
    //        if (ch < 'A' || ch > 'Z')
    //        {
    //            System.out.println("输入错误，请重新输入");
    //            ch = getChar();
    //        }
    //        return ch;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            char[] d = "0Mmonday000Ttuesday00WwednesdayTthursday0Ffriday000Ssaturday0Ssunday000".ToCharArray();
            Console.Write("请输入单词：");
            char[] a = Console.ReadLine().ToCharArray();
            int i;
            for (i = 0; i < d.Length; i++)
            {
                if (a[0] == d[i] || a[0] == d[i + 1])
                {
                    if (a[1] == d[i + 2])
                    {
                        break;
                    }
                }
            }
            if (i > 62)
            {
                Console.WriteLine("您输入的单词无效。");
            }
            else
            {
                string result = i / 10 + 1 == 7 ? "天" : Convert.ToString(i / 10 + 1);
                Console.WriteLine($"您输入的单词为星期{result}");
            }
            Console.ReadLine();
        }
    }
}
