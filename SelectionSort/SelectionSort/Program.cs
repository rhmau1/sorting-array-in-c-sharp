using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nilai = { 69, 89, 31, 47, 39 };
            SelectionSort(nilai);
        }

        public static void SelectionSort( int[] bilangan)
        {
            Console.WriteLine("===SEBELUM===");
            foreach ( int i in bilangan)
            {
                Console.Write($"{i} ");
            }

            //logic selection sort
            for(int i=0;  i<bilangan.Length; i++)
            {
                int indexArray = i;
                for(int j = i; j< bilangan.Length; j++)
                {
                    if (bilangan[indexArray] > bilangan[j])
                    {
                        indexArray = j;
                    }
                } 
                //swap
                int temp = bilangan[i];
                bilangan[i] = bilangan[indexArray];
                bilangan[indexArray] = temp;
            }

            Console.WriteLine("\n===SESUDAH===");
            foreach (int i in bilangan)
            {
                Console.Write($"{i} ");
            }

        } 
    }
}
