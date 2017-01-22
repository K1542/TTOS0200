using System;

namespace H2T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int i, j, tmp, sum=0, max, min;

            Console.Write("Anna pisteitä:\n");
            for (i = 0; i < arr1.Length; i++)
            {
                Console.Write("Pisteet: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr1[0];
            min = arr1[0];
            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            for (i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }
            int TotalSum = sum - max - min;
            Console.Write("\nSumma: " + TotalSum);
            Console.ReadLine();
        }
    }
        }
