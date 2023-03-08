using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nilai = { 99, 87, 26, 45, 100, 67 };
            BubbleSortInt(nilai);

            double[] ipk = { 1.4, 4.0, 3.7, 2.3 };
            BubbleSortDouble(ipk);

            string[] nama = { "stivani", "sulthon", "daffa", "rahma" };
            BubbleSortString(nama);
        }

        public static void BubbleSortInt(int[] bilangan)
        {
            Console.WriteLine("===SEBELUM===");
            foreach(int bil in bilangan) 
            {
                Console.Write($"{bil} ");
            }

            //logic
            for (int i = 0; i < bilangan.Length; i++)
            {
                for(int j = 0;  j < bilangan.Length-1; j++)
                {
                    //kalau nilai saat ini lebih besar daripada nilai selanjutnya
                    if (bilangan[j] > bilangan[j+1] )
                    {
                        int temp = bilangan[j];
                        bilangan[j] = bilangan[j + 1];
                        bilangan[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\n===SESUDAH===");
            foreach (int bil in bilangan)
            {
                Console.Write($"{bil} ");
            }
        }

        public static void BubbleSortDouble (double[] angka)
        {
            Console.WriteLine("\n\n===SEBELUM===");
            foreach (double bil in angka)
            {
                Console.Write($"{bil} - ");
            }

            for (int i =0; i<angka.Length; i++)
            {
                for (int j=0; j<angka.Length-1; j++)
                {
                    if (angka[j] > angka[j + 1])
                    {
                        double temp = angka[j];
                        angka[j] = angka[j + 1];
                        angka[j + 1] = temp; 
                    }
                }
            }

            Console.WriteLine("\n===SESUDAH===");
            foreach (double bil in angka)
                Console.Write($"{bil} - ");
            }

        public static void BubbleSortString(string[] kata)
        {
            Console.WriteLine("\n\n===SEBELUM===");
            foreach(string k in kata)
            {
                Console.Write($"{k} ");
            }

            //untuk logic tetap pakai int
            for (int i = 0; i < kata.Length; i++)
            {
                for (int j=0; j < kata.Length-1; j++)
                {
                    if (kata[j].CompareTo(kata[j+1]) > 0)
                    {
                        string temp = kata[j];
                        kata[j] = kata[j + 1];
                        kata[j + 1] = temp;
                    }
                }
            } 
            Console.WriteLine("\n===SESUDAH===");
            foreach (string k in kata)
            {
                Console.Write($"{k} ");
            }
        }

        public static void BubbleSortChar(char[] huruf)
        {
            Console.Write("\n\n===SEBELUM===");
            foreach (char h in huruf)
            {
                Console.Write($"{h} ");
            }

            //untuk logic tetap pakai int
            for (int i = 0; i < huruf.Length; i++)
            {
                for (int j = 0; j < huruf.Length - 1; j++)
                {
                    if (huruf[j] > huruf[j+1])
                    {
                        char temp = huruf[j];
                        huruf[j] = huruf[j + 1];
                        huruf[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n===SESUDAH===");
            foreach (char h in huruf)
            {
                Console.Write($"{h} ");
            }
        }

    }
    }
 