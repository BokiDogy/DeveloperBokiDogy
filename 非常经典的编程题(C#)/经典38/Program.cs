﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典38
{
    //    【程序38】   
    //题目：写一个函数，求一个字符串的长度，在main函数中输入字符串，并输出其长度。   
    ///*………………
    //*……题目意思似乎不能用length()函数     */
    //import java.util.*;
    //    public class lianxi38
    //    {
    //        public static void main(String[] args)
    //        {
    //            Scanner s = new Scanner(System.in);
    //            System.out.println("请输入一个字符串：");
    //            String str = s.nextLine();
    //            System.out.println("字符串的长度是：" + str.length());
    //        }
    //    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个字符串： ");
            string a = Console.ReadLine();
            int n = StrLenth(a);
            Console.WriteLine($"\n这个字符串的长度为：{n}");
            Console.ReadLine();
        }
        public static int StrLenth(string a)
        {
            char[] b = a.ToCharArray();
            return b.Length;
        }
    }
}
