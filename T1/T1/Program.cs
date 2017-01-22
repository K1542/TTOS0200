using System;

namespace H2T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i, sum=0;
  
            Console.Write("Input 10 elements in the array :\n");  
            for(i=0; i<5; i++)  
            {  
	            Console.Write("element - {0} : ",i);
	            arr[i] = Convert.ToInt32(Console.ReadLine());  		
            }
            Console.Write("\nElements in array are: ");  
            for(i=0; i<5; i++)  
            {  
                Console.Write("{0}  ", arr[i]);  
            }
            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[1,4];
            }
            Console.Write("\n");
            Console.Write("Summa: " + sum);
            Console.ReadLine();
      }
        }
}