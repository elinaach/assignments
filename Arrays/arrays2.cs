using System;

namespace Arrays_2_Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 10, 4, -4, 7, 0, 9, 1, 3, 7, -5 };

            Console.WriteLine("The negatives elements are: ");
               for (int i = 0; i < myArr.Length; i++)
               {
                 if (myArr[i] < 0 )
                 Console.Write(myArr[i] + " ");
               }
            Console.WriteLine("\nThe uneven elements are: ");
               for (int i = 0; i < myArr.Length; i++)
               {
                 if (myArr[i] % 2 != 0)
                    Console.Write(myArr[i] + " ");
               }
              
             int countOdd = 0;
             Console.WriteLine("\nCount of uneven elements: ");
             for (int i = 0; i < myArr.Length; i++)
               {
                 if (myArr[i] % 2 != 0)
                    countOdd++;
               }
               Console.Write(countOdd);

             Console.WriteLine("\nEach second element: ");
             for (int i = 1; i < myArr.Length; i += 2) 
              {
               
               Console.Write( myArr[i] + " ");

              }
              
              int sum = 0;
              double average;
              Console.WriteLine("\nThe average number: ");
              for (int i = 0; i < myArr.Length; i++)
               {
                 sum += myArr[i];
               }
               average = sum / 10;
               Console.Write(average);

              int belowAverage = 0;
              for (int i = 0; i < myArr.Length; i++)
               {
                 if (myArr[i] < average)
                 belowAverage++;
               }
               Console.WriteLine("\nThere are " + belowAverage + " elements that are below the average value of the array");
             
        }
    }
}