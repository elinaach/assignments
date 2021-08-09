using System;

namespace Arrays_3_Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] grades = new byte [10];

            int g = 0;
            while (g < grades.Length)
{
            Console.WriteLine("Please enter the grade from 0 to 10: ");
            byte inputGrades;
            if ((!Byte.TryParse(Console.ReadLine(), out inputGrades)) || (inputGrades < 0) || (inputGrades > 10))
                {
                Console.WriteLine("Incorrect input! Please enter the grade from 0 to 10.");
                return;
                }
            else 
                {
                grades[g] = inputGrades;
                }
            g++;
            }
           

           int studentsFailed = 0;
           int studentsA = 0;

           for (int i = 0; i < 10; i++)
            {
                if (grades[i] < 4)
                    studentsFailed++;

                else if (grades[i] == 10)
                    studentsA++;

            }
            Console.WriteLine("There are " + studentsFailed + " students who failed!");
            Console.WriteLine("There are " + studentsA + " students who had a 10!");
            
            int[] newHistogram = new int[11];

            for (int i = 0; i < 10; i++)
            {
                newHistogram[grades[i]]++;
            }
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{newHistogram[i]} students with the grade {i}!");
            }

        }
    }
}