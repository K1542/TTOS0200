using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[]{ 10, 20, 30, 40, 50 };
            int[] arr2 = new int[]{ 5, 15, 25, 35, 45 };
            int[] arr3 = arr1.Concat(arr2).ToArray();
            int i,j,tmp;
            for (i = 0; i < arr3.Length; i++)
            {
                for (j = i + 1; j < arr3.Length; j++)
                {
                    if (arr3[j] < arr3[i])
                    {
                        tmp = arr3[i];
                        arr3[i] = arr3[j];
                        arr3[j] = tmp;
                    }
                }
            }
                for (i = 0; i < arr3.Length; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.ReadLine();
        }
    }
}
