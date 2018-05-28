using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典49
{
//    【程序49】   
//题目：计算字符串中子串出现的次数
//import java.util.*;
//public class lianxi49
//    {
//        public static void main(String args[])
//        {
//            Scanner s = new Scanner(System.in);
//            System.out.print("请输入字符串：");
//            String str1 = s.nextLine();
//            System.out.print("请输入子串：");
//            String str2 = s.nextLine();
//            int count = 0;
//            if (str1.equals("") || str2.equals(""))
//            {
//                System.out.println("你没有输入字符串或子串,无法比较!");
//                System.exit(0);
//            }
//            else
//            {
//                for (int i = 0; i <= str1.length() - str2.length(); i++)
//                {
//                    if (str2.equals(str1.substring(i, str2.length() + i)))
//                        //这种比法有问题，会把"aaa"看成有2个"aa"子串。 
//                        count++;
//                }
//                System.out.println("子串在字符串中出现: " + count + " 次");
//            }
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串，以回车键结束：");
            string a = Console.ReadLine();
            char[] Mom = a.ToCharArray();
            Console.WriteLine("请输入子字符串，以回车键结束：");
            string b = Console.ReadLine();
            char[] Son = b.ToCharArray();
            int count = 0;
            for(int i=0;i<Mom.Length-Son.Length+1;i++)
            {
                if(Mom[i]==b[0])
                {
                    for(int j=0;j<Son.Length;j++)
                    {
                        if(Mom[i+j]!=Son[j])
                        {
                            break;
                        }
                        if(j==Son.Length-1)
                        {
                            count++;
                            i = i + Son.Length;
                        }
                    }
                }
            }
            Console.WriteLine($"子串{b}在字符串{a}中出现的次数：{count}");
            Console.ReadLine();
        }
    }
}
