using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nilai = { 15, 60, 25, 78, 90, 100, 76 };
            QuickSort(nilai);
        } 

        public static void QuickSort(int[] angka)
        {
            Console.WriteLine("==SEBELUM==");            
            foreach (int Angka in angka)
            {
                Console.Write($"{Angka} ");
            }

            QuickSortAlgo(angka, 0, angka.Length-1);
             
            Console.WriteLine("\n==SESUDAH==");

            foreach (int Angka in angka)
            {
                Console.Write($"{Angka} ");
            }

        }

        public static void QuickSortAlgo(int[] angka, int indexAwal, int indexAkhir)
        {
            int i = indexAwal, j = indexAkhir;
            int pivot = angka[indexAwal];

            //perulangan untuk mengecek apakah data masih bisa dicek atau tidak
            while (i <= j)
            {
                //kalau nilai di sebelah kiri kurang dari nilai pivot 
                while (angka[i] < pivot) //kalau mau desc dibalik jadi >
                {
                    i++;
                }
                //kalau nilai di sebelah kanan lebih dari nilai pivot
                while (angka[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tampungan = angka[i];
                    angka[i] = angka[j];
                    angka[j] = tampungan;
                    i++;
                    j--;
                }                
            }
            if (indexAwal < j)
            {
                QuickSortAlgo(angka, indexAwal, j);
            }

            if (i < indexAkhir)
            {
                QuickSortAlgo(angka, i, indexAkhir);
            }
        }
    }
}
