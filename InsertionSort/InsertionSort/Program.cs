using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nilai = { 90, 100, 82, 75, 25, 83 };
            InsertionSort(nilai);
        }  

        public static void InsertionSort(int[] bilangan)
        {
            Console.WriteLine("===SEBELUM===");
            foreach(int i in bilangan)
            {
                Console.Write($"{i} ");
            }

            for(int i = 1; i <bilangan.Length; i++)
            {
                for(int j = i; j >0; j--)
                {
                    if (bilangan[j] < bilangan[j - 1])
                    {
                        int temp = bilangan[j];
                        bilangan[j] = bilangan[j - 1];
                        bilangan[j - 1] = temp;
                    }
                }
            }

            Console.WriteLine("===SESUDAH===");
            foreach (int i in bilangan)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
