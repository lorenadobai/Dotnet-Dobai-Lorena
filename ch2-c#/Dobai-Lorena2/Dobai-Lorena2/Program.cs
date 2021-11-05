using System;

namespace Dobai_Lorena2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -5;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int[] A = { -5 };
            int[] B = A;
            Console.WriteLine(A[0]);
            Console.WriteLine(B[0]);
            B[0] = 10;
            Console.WriteLine(A[0]);
            Console.WriteLine(B[0]);
            // Test(A);
            //Console.WriteLine(A[0]);
            // Test(a);
            // Console.WriteLine(a);
            //Int32 x = 5;
            //string x = "caleb";
            int x = (int)5.9999999;
            double y = 5;
            Console.WriteLine(x);
        }
        /*static void Test(int[] a)
        {
            a[0] = 100;
        }*/
       /* static void Test(int x)
        {
            x = 100;
        }*/
    }
}
