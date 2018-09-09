//Vladimir Galkin
//1. Попробовать оптимизировать пузырьковую сортировку.Сравнить количество операций сравнения 
//   оптимизированной и не оптимизированной программы. Написать функции сортировки, которые возвращают количество операций.
//2. *Реализовать шейкерную сортировку.
//4. * Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotringAnalysis
{
    class Program
    {
        public static int[] FillArray(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10);
            }
            PrintArray(arr);
            return arr;
        }

        public static int[] CloneArray(int[] a)
        {
            int[] arr = new int[a.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = a[i];
            }
            return arr;
        }

        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static int Bubble_Sort(int[] a)
        {
            int[] arr = CloneArray(a);
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        counter++;
                    }
                }
            }
            PrintArray(arr);
            return counter;
        }

        public static int My_Bubble_Sort(int[] a)
        {
            int[] arr = CloneArray(a);
            int mycounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        mycounter++;
                        flag = true;
                    }
                }
                if (flag!=true)
                {
                    break;
                }
            }
            PrintArray(arr);

            return mycounter;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }





        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            //int[] arr2 = new int[20];
            //int[] arr3 = new int[30];
            FillArray(arr1);
            //FillArray(arr2);
            //FillArray(arr3);
            Console.WriteLine("Сортировка bubble 1 = " + Bubble_Sort(arr1) + "\n");
            //PrintArray(arr1);
            Console.WriteLine("Сортировка My bubble sort = " + My_Bubble_Sort(arr1) + "\n");
            PrintArray(arr1);


            //Console.WriteLine("Сортировка bubble 2 = " + Bubble_Sort(arr2));
            //Console.WriteLine("Сортировка bubble 3 = " + Bubble_Sort(arr3));
            //Console.WriteLine("Сортировка bubble 3 = " + My_Bubble_Sort(arr2));
            //Console.WriteLine("Сортировка bubble 3 = " + My_Bubble_Sort(arr3));

        }
    }
}
