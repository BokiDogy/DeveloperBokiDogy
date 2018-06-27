using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典18
{
    //    【程序18】   
    //题目：两个乒乓球队进行比赛，各出三人。甲队为a,b,c三人，乙队为x,y,z三人。已抽签决定比赛名单。有人向队员打听比赛的名单。a说他不和x比，c说他不和x,z比，请编程序找出三队赛手的名单。   
    //public class lianxi18
    //    {
    //        static char[] m = { 'a', 'b', 'c' };
    //        static char[] n = { 'x', 'y', 'z' };
    //        public static void main(String[] args)
    //        {
    //            for (int i = 0; i < m.length; i++)
    //            {
    //                for (int j = 0; j < n.length; j++)
    //                {
    //                    if (m[i] == 'a' && n[j] == 'x')
    //                    {
    //                        continue;
    //                    }
    //                    else if (m[i] == 'a' && n[j] == 'y')
    //                    {
    //                        continue;
    //                    }
    //                    else if ((m[i] == 'c' && n[j] == 'x')
    //                    || (m[i] == 'c' && n[j] == 'z'))
    //                    {
    //                        continue;
    //                    }
    //                    else if ((m[i] == 'b' && n[j] == 'z')
    //                    || (m[i] == 'b' && n[j] == 'y'))
    //                    {
    //                        continue;
    //                    }
    //                    else
    //                        System.out.println(m[i] + " vs " + n[j]);
    //                }
    //            }
    //        }
    //    }


    class Program
    {
        static void Main(string[] args)
        {
            string[] Jia = new string[3] { "a", "b", "c" };
            string[] Yi = new string[3] { "x", "y", "z" };
            Console.WriteLine("赛程表为：");
            for (int i = 1; i <= Jia.Length; i++)
            {
                for (int j = 1; j <= Yi.Length; j++)
                {
                    if ((i == 1 && j == 1) || (i == 3 && (j == 1 || j == 3)))
                    {
                        continue;
                    }
                    Console.WriteLine($"{Jia[i - 1]}  vs  {Yi[j - 1]}");
                }
            }
            Console.ReadLine();
        }
    }
}
