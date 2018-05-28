using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典29
{
//    【程序29】   
//题目：求一个3*3矩阵对角线元素之和
//import java.util.*;
//public class lianxi29
//    {
//        public static void main(String[] args)
//        {
//            Scanner s = new Scanner(System.in);
//            int[][] a = new int[3][3];
//            System.out.println("请输入9个整数：");
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    a[i][j] = s.nextInt();
//                }
//            }
//            System.out.println("输入的3 * 3 矩阵是:");
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    System.out.print(a[i][j] + " ");
//                }
//                System.out.println();
//            }
//            int sum = 0;
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    if (i == j)
//                    {
//                        sum += a[i][j];
//                    }
//                }
//            }
//            System.out.println("对角线之和是：" + sum);
//        }
//    }

    class Program
    {
        static void Main(string[] args)
        {
            int [ , ] a= new int[3,3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    a[i, j] = i + j;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine("");
            }
            int sum = 0;
            for(int i=0;i<3;i++)
            {
                sum += a[i, i];
            }
            for(int i=0;i<3;i++)
            {
                sum += a[i, 3 - 1 - i];
            }
            Console.WriteLine($"对角线之和为:{sum}");
            Console.ReadLine();
        }
    }
}
