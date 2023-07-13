using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zd36();
        }
        static void zd34()
        {
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100, 1000);
            }

            for (int i = 0; i < size; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine(count);


        }
        static void zd36()
        {
            //Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
            //[3, 7, 23, 12] -> 19
            //[-4, -6, 89, 6]-> 0
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100, 1000);
            }
            for (int i = 0; i < size; i++)
            {
                if (i % 2 != 0) 
                {
                    count += array[i];
                    Console.WriteLine(" qq"+count);
                }
            }
            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine(count);
        }
    }
}

