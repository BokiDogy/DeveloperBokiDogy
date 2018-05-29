using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典14
{
//    【程序14】  
//题目：输入某年某月某日，判断这一天是这一年的第几天？   
//import java.util.*;
//    public class lianxi14
//    {
//        public static void main(String[] args)
//        {
//            int year, month, day;
//            int days = 0;
//            int d = 0;
//            int e;
//            input fymd = new input();
//            do
//            {
//                e = 0;
//                System.out.print("输入年：");
//                year = fymd.input();
//                System.out.print("输入月：");
//                month = fymd.input();
//                System.out.print("输入天：");
//                day = fymd.input();
//                if (year < 0 || month < 0 || month > 12 || day < 0 || day > 31)
//                {
//                    System.out.println("输入错误，请重新输入！");
//                    e = 1;
//                }
//            } while (e == 1);
//            for (int i = 1; i < month; i++)
//            {
//                switch (i)
//                {
//                    case 1:
//                    case 3:
//                    case 5:
//                    case 7:
//                    case 8:
//                    case 10:
//                    case 12:
//                        days = 31;
//                        break;
//                    case 4:
//                    case 6:
//                    case 9:
//                    case 11:
//                        days = 30;
//                        break;
//                    case 2:
//                        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
//                        {
//                            days = 29;
//                        }
//                        else
//                        {
//                            days = 28;
//                        }
//                        break;
//                }
//                d += days;
//            }
//            System.out.println(year + "-" + month + "-" + day + "是这年的第" + (d + day) + "天。");
//        }
//    }
//    class input
//    {
//        public int input()
//        {
//            int value = 0;
//            Scanner s = new Scanner(System.in);
//            value = s.nextInt();
//            return value;
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int year, month, date;
            Console.Write("请输入一个大于1582的年份数字：");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入一个月份数字：");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入一个日期数字：");
            date = Convert.ToInt32(Console.ReadLine());
            int days = 0;
            int monthday = 31;
            switch (month)
            {
                case 1:
                    break;
                case 2:
                    monthday = 28;
                    days = 31;
                    break;
                case 3:
                    days = 59;
                    break;
                case 4:
                    monthday = 30;
                    days = 90;
                    break;
                case 5:
                    days = 120;
                    break;
                case 6:
                    monthday = 30;
                    days = 151;
                    break;
                case 7:
                    days = 181;
                    break;
                case 8:
                    days = 212;
                    break;
                case 9:
                    monthday = 30;
                    days = 243;
                    break;
                case 10:
                    days = 273;
                    break;
                case 11:
                    monthday = 30;
                    days = 304;
                    break;
                case 12:
                    days = 334;
                    break;
            }
            if (((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) && month >= 3)
            {
                days++;
            }
            days += date;
            Console.WriteLine($"{year}年{month}月{date}日为{year}年的第{days}天,当月有{monthday}天");
            Console.ReadLine();
        }
    }
}
