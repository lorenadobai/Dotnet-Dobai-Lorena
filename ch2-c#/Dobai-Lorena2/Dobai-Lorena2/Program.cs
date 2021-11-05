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
            Console.WriteLine(y);
            //float f = 5.5f;//when we do not have enough space
            double d = 5.5;
            decimal d2 = 10.5M;//precizie,working with money
            // double t = double.NaN;
            // Console.WriteLine(double.IsNaN(t));
            // double t = Math.Pow(d, 2);
            // Console.WriteLine(t);
            double Y = 50.5;
            double X = 300;
            Console.WriteLine(Math.Round(Y,0,MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Floor(Y));
            Console.WriteLine(Math.Ceiling(Y));
            Console.WriteLine(Math.Truncate(Y));
            Console.WriteLine(Math.Max(X, Y));
            Console.WriteLine(Math.Min(X, Y));
            Console.WriteLine(Math.Abs(-50));//scrie varianta pozitiva
            Console.WriteLine(Math.Sign(Y));//verifica daca nr este pozitiv sau negativ:-1 nr negativ,1 nr pozitiv, 0 nr este 0
            char letter = 'a';
            int number = 'a';
            char c = (char)977;
            Console.WriteLine("Hello\tLore");
            Console.WriteLine(c);
            string name = "Lore";
            string name2 = name;
            //name += " Curry";
            Console.WriteLine(name);
            Console.WriteLine(name2);
            char[] ch = { 'h', 'e', 'l', 'l', 'o' };
            string greetings = new string(ch);
            Console.WriteLine(greetings);
            string message = $"Hello my name is {name}, and I like to say {greetings}";
            Console.WriteLine(message);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.CompareTo("Lore"));
            Console.WriteLine(name.Remove(1, 2));
           // Console.WriteLine(name.Trim());
            string blabla = "hello my name is";
            string[] words=blabla.Split(' ');
            Console.WriteLine(words[1]);
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
