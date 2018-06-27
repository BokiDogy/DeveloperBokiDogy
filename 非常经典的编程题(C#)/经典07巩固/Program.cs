using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典07巩固
{
    //将一个小写字母单词组成的字符串数组换字母顺序排列
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;
            string[] a = new string[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"请输入第{i + 1}个单词：");
                a[i] = Console.ReadLine();
            }
            Console.WriteLine($"排序前的结果为：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]},");
            }
            Console.WriteLine("\n-------------------------------");
            for (int i = 0; i < a.Length; i++)
            {
                for (int k = i + 1; k < a.Length; k++)
                {
                    char[] p = a[k].ToCharArray();
                    char[] q = a[i].ToCharArray();
                    if (CompareString(p, q) == 1)
                    {
                        string temp = a[k];
                        a[k] = a[i];
                        a[i] = temp;
                    }
                }
            }
            Console.WriteLine($"排序后的结果为：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]},");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// 字符串对比
        /// </summary>
        /// <param name="str1">输入第一个字符串str1</param>
        /// <param name="str2">输入第二个字符串str2</param>
        /// <returns>返回result值：str1<str2则返回1,str1>str2则返回2，str1==str2返回0</returns>
        public static int CompareString(char[] str1, char[] str2)
        {
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



