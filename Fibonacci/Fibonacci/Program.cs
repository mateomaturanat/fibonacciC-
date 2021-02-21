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
            objFibonacciModel.setSize(10);
            objFibonacciModel.showFibonacci();
            Console.ReadKey();
        }
    }
}
