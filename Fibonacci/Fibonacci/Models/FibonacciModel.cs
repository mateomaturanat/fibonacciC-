using System;
using System.Collections.Generic;
using System.Linq;


namespace Fibonacci.Models
{
    public class FibonacciModel
    {
        //This atribute is for assign size of sequence fibonacci
        private int size;
        //This List is for save numbers of sequence
        private List<int> list_fibonacci = new List<int>();

        public FibonacciModel(int size, List<int> list_fibonacci)
        {
            this.size = size;
            this.list_fibonacci = list_fibonacci;
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
        //This function is for generate the fibonacci sequence
        private void fibonacci(int num)
        {
            if (num > 1)
            {
                list_fibonacci.Add(list_fibonacci.ElementAt(num - 1) + list_fibonacci.ElementAt(num - 2));
            }
            else if (num == 1)
            {
                list_fibonacci.Add(1);
            }
            else if (num == 0)
            {
                list_fibonacci.Add(0);
            }
            else
            {
                Console.WriteLine("El tamaño debe ser igual o superior a 1");
            }
        }
        public void show_fibonacci()
        {
            for (int i = 0; i < this.size; i++)
            {
                fibonacci(i);
                Console.Write(this.list_fibonacci.ElementAt(i) + ", ");
            }
        }
    }
}
