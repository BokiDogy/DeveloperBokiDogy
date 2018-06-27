using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典23
{
//    【程序23】   
//题目：有5个人坐在一起，问第五个人多少岁？他说比第4个人大2岁。问第4个人岁数，他说比第3个人大2岁。问第三个人，又说比第2人大两岁。问第2个人，说比第一个人大两岁。最后问第一个人，他说是10岁。请问第五个人多大？   
//public class lianxi23
//    {
//        public static void main(String[] args)
//        {
//            int age = 10;
//            for (int i = 2; i <= 5; i++)
//            {
//                age = age + 2;
//            }
//            System.out.println(age);
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"第五个人的岁数为{10 + 2 + 2 + 2 + 2}岁");
            Console.ReadLine();
        }
    }
}
