using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;

            Console.WriteLine($"Subtraction: {a} - {b} = {a-b}");
            Console.WriteLine($"Addition: {a} + {b} = {a+b}");
            Console.WriteLine($"Multiplication: {a} * {b} = {a*b}");
            Console.WriteLine($"Division: {a} / {b} = {a/b}");
            Console.WriteLine($"Mode: {a} % {b} = {a%b}");
            Console.WriteLine($"Increment: ++{a} = {++a}");
            Console.WriteLine($"Sin: Sin({a}) = {Math.Sin(a)}");
        }
    }
}
