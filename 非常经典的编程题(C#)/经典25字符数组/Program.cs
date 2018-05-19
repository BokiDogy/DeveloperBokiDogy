using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典25字符数组
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isHuiWen= true;
            Console.Write("请输入一个正整数：");
            char[] n = Console.ReadLine().ToCharArray();
            for(int i=0;i<n.Length;i++)
            {
                if(n[i]!= n[n.Length-i-1])
                {
                    isHuiWen = false;
                    break;
                }
            }
            string result = isHuiWen ? "是" : "不是";
            Console.WriteLine($"您输入的数字{result}回文数。");
            Console.ReadLine();
        }
    }
}
