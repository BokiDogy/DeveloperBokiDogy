using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典40
{
    //    【程序40】   
    //题目：字符串排序。   
    //public class lianxi40
    //    {
    //        public static void main(String[] args)
    //        {
    //            int N = 5;
    //            String temp = null;
    //            String[] s = new String[N];
    //            s[0] = "matter";
    //            s[1] = "state";
    //            s[2] = "solid";
    //            s[3] = "liquid";
    //            s[4] = "gas";
    //            for (int i = 0; i < N; i++)
    //            {
    //                for (int j = i + 1; j < N; j++)
    //                {
    //                    if (compare(s[i], s[j]) == false)
    //                    {
    //                        temp = s[i];
    //                        s[i] = s[j];
    //                        s[j] = temp;
    //                    }
    //                }
    //            }
    //            for (int i = 0; i < N; i++)
    //            {
    //                System.out.println(s[i]);
    //            }
    //        }
    //        static boolean compare(String s1, String s2)
    //        {
    //            boolean result = true;
    //            for (int i = 0; i < s1.length() && i < s2.length(); i++)
    //            {
    //                if (s1.charAt(i) > s2.charAt(i))
    //                {
    //                    result = false;
    //                    break;
    //                }
    //                else if (s1.charAt(i) < s2.charAt(i))
    //                {
    //                    result = true;
    //                    break;
    //                }
    //                else
    //                {
    //                    if (s1.length() < s2.length())
    //                    {
    //                        result = true;
    //                    }
    //                    else
    //                    {
    //                        result = false;
    //                    }
    //                }
    //            }
    //            return result;
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;
            string[] a = new string[n];
            Console.WriteLine($"请输入任意{a.Length}个字符串：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"请输入第{i + 1}个字符串:");
                a[i] = Console.ReadLine();
                if (i == a.Length - 1)
                {
                    Console.WriteLine("输入结束");
                }
            }
            Console.WriteLine("排序前的结果为：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]}\n");
            }
            Console.WriteLine("");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (CompareString(a[i], a[j]) == 1)
                    {
                        string temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("排序后的结果为：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]}\n");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
        /// <summary>
        /// 字符串对比
        /// </summary>
        /// <param name="str1">输入第一个字符串a</param>
        /// <param name="str2">输入第二个字符串b</param>
        /// <returns>返回result值：a<b则返回1,a<b返回2，a==b返回0</returns>
        public static int CompareString(string a, string b)
        {
            char[] str1 = a.ToCharArray();
            char[] str2 = b.ToCharArray();
            int result = 0;
            int i;
            for (i = 0; i < (str1.Length > str2.Length ? str2.Length : str1.Length) && result == 0; i++)
            {
                if (str1[i] != str2[i])
                {
                    result = str1[i] > str2[i] ? 2 : 1;
                    break;
                }
                i++;
            }
            if (i == (str1.Length > str2.Length ? str2.Length : str1.Length))
            {
                result = str1.Length > str2.Length ? 2 : 1;
            }
            return result;
        }
    }
}

