using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 经典33
{
    //【程序33】  
    //题目：打印出杨辉三角形（要求打印出10行如下图）      
    //            1   
    //          1    1   
    //        1    2    1   
    //      1    3    3    1   
    //    1    4    6    4    1   
    //1    5    10    10    5    1   
    //…………
    //public class lianxi33 {
    //public static void main(String[] args) {
    //    int[][] a = new int[10][10];
    //   for(int i=0; i<10; i++) {
    //    a[i][i] = 1;
    //    a[i][0] = 1;
    //   }
    //   for(int i=2; i<10; i++) {
    //    for(int j=1; j<i; j++) {
    //     a[i][j] = a[i-1][j-1] + a[i-1][j];
    //    }
    //   }
    //     for(int i=0; i<10; i++) {
    //    for(int k=0; k<2*(10-i)-1; k++) {
    //     System.out.print(" ");
    //    }
    //    for(int j=0; j<=i; j++) {
    //     System.out.print(a[i][j] + "   ");
    //    }
    //    System.out.println();
    //   }
    //}
    //}
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                n[i, i] = 1;
                n[i, 0] = 1;
            }
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    n[i, j] = n[i - 1, j - 1] + n[i - 1, j];
                }
            }
            string kg = "";
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10 - i; k++)
                {
                    Console.Write("   ");
                }
                for (int j = 0; j < 10; j++)
                {
                    if (n[i, j] == 0)
                    {
                        continue;
                    }
                    kg = n[i, j] > 100 ? "     " : (n[i, j] > 10 ? "     " : "     ");
                    Console.Write($"{n[i, j]}{kg}");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
