using System;
using System.Collections.Generic;

namespace Dobai_Lorena //used for organization
{
    class Program //has members(method)
    {
        static void Main(string[] args) //a method-contains a block of code
        {
            //Program myProgram = new Program();
            //myProgram.Print();
            //Console.WriteLine(args[0]);
            string name= Console.ReadLine();
            // Console.WriteLine("hello "+name+"!");
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("yo");
            //int x = -5; //declaration initialization
            // int X = 50;
            //var y = "hello";
            //string x = "caleb";
            // Console.WriteLine(x+" is weird.");
            //int? y=null; //declaration
            //y = 5; //initialization
            //Console.WriteLine(y);
            /*uint b = 5;
            char c = 'c';
            float d = 5.5F;
            double e = 5.5;
            decimal f = 5.5M;//precizie exacta (ex:cand lucrezi cu money)
            bool g = true;
            string h = "hello";*/
            int a = -5;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        /*void Print()
        {
            Console.WriteLine("hey");
            Console.WriteLine("Hello World!"); //statement
            Console.WriteLine("Best friend!");
        }*/
    }
}
//create the method->invoke the method
//namespace->classes->members->method->statements
//variable- stores some value
//identifier- what we call the variable
//expression- evaluates to a value
//operator-it workd on operands
//operand-the things that the operator works on
//'C'-character, "C"-string