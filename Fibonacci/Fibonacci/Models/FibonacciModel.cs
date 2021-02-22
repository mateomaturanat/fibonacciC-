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
        public void Set_Size(int size)
        {
            this.size = size;
        }
        //This function is for generate the fibonacci sequence
        private void Fibonacci(int num)
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
        public void Show_Fibonacci()
        {
            for (int i = 0; i < this.size; i++)
            {
                Fibonacci(i);
                Console.Write(this.list_fibonacci.ElementAt(i) + ", ");
            }
            Is_Prime();
        }
        private void Is_Prime()
        {
            bool is_Prime = true;
            for(int i = 3; i < list_fibonacci.ElementAt(this.size - 1); i++)
            {
                if(list_fibonacci.ElementAt(this.size - 1) % i==0)
                {
                    is_Prime = false;
                    break;
                }
            }
            if (is_Prime)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }

    }
}
