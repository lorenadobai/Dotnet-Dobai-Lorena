using System;
using System.Collections.Generic;

namespace Dobai_Lorena //used for organization
{
    class Program //has members(method)
    {
        static void Main(string[] args) //a method-contains a block of code
        {
            Program myProgram = new Program();
            myProgram.Print();
            //Console.WriteLine(args[0]);
            var name= Console.ReadLine();
            // Console.WriteLine("hello "+name+"!");
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("yo");
            //int x = 5;
            // int X = 50;
            //var y = "hello";
            string x = "caleb";
            Console.WriteLine(x+" is weird.");
        }
        void Print()
        {
            Console.WriteLine("hey");
            Console.WriteLine("Hello World!"); //statement
            Console.WriteLine("Best friend!");
        }
    }
}
//create the method->invoke the method
//namespace->classes->members->method->statements
//variable- stores some value
//identifier- what we call the variable
//expression- evaluates to a value
//operator-it workd on operands
//operand-the things that the operator works on