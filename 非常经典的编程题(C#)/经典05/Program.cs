using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 经典05
{
//    【程序5】   
//题目：利用条件运算符的嵌套来完成此题：学习成绩> =90分的同学用A表示，60-89分之间的用B表示，60分以下的用C表示。   
//import java.util.*;
//    public class lianxi05
//    {
//        public static void main(String[] args)
//        {
//            int x;
//            char grade;
//            Scanner s = new Scanner(System.in);
//            System.out.print("请输入一个成绩: ");
//            x = s.nextInt();
//            grade = x >= 90 ? 'A'
//                  : x >= 60 ? 'B'
//                  : 'C';
//            System.out.println("等级为：" + grade);

//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int score = ShuRu("学生的分数n");
            string result = "";
            if (score >= 0 && score <= 100)
            {
                result = score >= 90 ? "A" : score < 60 ? "C" : "B";
                WriteLine($"该学生的成绩为：{result}");
            }
            else
            {
                WriteLine("您输入的分数无效");
            }
            ReadLine();
        }
        /// <summary>
        /// 输入函数
        /// </summary>
        /// <param name="des">屏幕提示</param>
        /// <returns>输入的x值</returns>
        public static int ShuRu(string des)
        {
            int x;
            Console.Write($"请输入{des}=");
            return x = Convert.ToInt32(Console.ReadLine());
        }
    }
}
