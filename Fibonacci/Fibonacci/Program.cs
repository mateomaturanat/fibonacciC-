using Fibonacci.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciModel objFibonacciModel = new FibonacciModel();
            //here we assign the size of the sequence
            objFibonacciModel.Set_Size(8);
            objFibonacciModel.Show_Fibonacci();
            Console.ReadKey();
        }
    }
}
