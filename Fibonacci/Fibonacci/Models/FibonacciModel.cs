using System;
using System.Collections.Generic;
using System.Linq;


namespace Fibonacci.Models
{
    public class FibonacciModel
    {
        private int size;
        private List<int> listFibonacci = new List<int>();

        public FibonacciModel(int size, List<int> listFibonacci)
        {
            this.size = size;
            this.listFibonacci = listFibonacci;
        }
        public FibonacciModel()
        {
        }
        public int getSize()
        {
            return size;
        }
        public void setSize(int size)
        {
            this.size = size;
        }
        private void fibonacci(int num)
        {
            if (num > 1)
            {
                listFibonacci.Add(listFibonacci.ElementAt(num - 1) + listFibonacci.ElementAt(num - 2));
            }
            else if (num == 1)
            {
                listFibonacci.Add(1);
            }
            else if (num == 0)
            {
                listFibonacci.Add(0);
            }
            else
            {
                Console.WriteLine("El tamaño debe ser igual o superior a 1");
            }
        }
        public void showFibonacci()
        {
            for (int i = 0; i < this.size; i++)
            {
                fibonacci(i);
                Console.Write(this.listFibonacci.ElementAt(i) + ", ");
            }
        }
    }
}
