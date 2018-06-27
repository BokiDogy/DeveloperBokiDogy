using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典24字符数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个正整数：");
            char[] n = Console.ReadLine().ToCharArray();
            Console.WriteLine($"你输入的数字是{n.Length}位数。");
            Console.WriteLine($"各位数逆序打印的结果为：");
            for(int i=n.Length-1;i>=0;i--)
            {
                Console.Write($"{n[i]}");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
