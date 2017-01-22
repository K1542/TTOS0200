using System;

namespace H2T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[arr1.Length - 1];
            int i, j, tmp, sum=0;

            Console.Write("Input elements in the array :\n");
            for (i = 0; i < arr1.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < arr1.Length; i++)
            {
                for (j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            
            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            // Pienimmän numeron poisto
            for (i = 0; i < 0; i++)
            {
                // indices in new array before the add position remains the same
                arr2[i] = arr1[i];

            }
            for (j = 0; j <= arr2.Length - 1; j++)
            {
                // indices in new array after the del position change by 1(move left)
                arr2[j] = arr1[j + 1];
            }

            for (i = 0; i < arr2.Length; i++)
            {
                sum += arr2[i];
            }
            Console.Write("\nSumma: " + sum);
            Console.ReadLine();
        }
    }
        }
