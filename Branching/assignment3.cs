using System;

namespace Assignments
{
    class Branching
    {
        public static void Main(string[] args)
        {

            char Grade;
            Console.WriteLine("Please enter the grade level of the exam! (Use capital letters) ");
            Grade = Convert.ToChar(Console.ReadLine());
            
            switch (Grade)
            {
                case 'A':
                    Console.WriteLine("Perfect! You are so clever!");
                    break;
                case 'B':
                    Console.WriteLine("Perfect! You are so clever!");
                    break;
                case 'C':
                    Console.WriteLine("Good! But You can do better!");
                    break;    
                case 'D':
                    Console.WriteLine("It is not good! You should study!");
                    break;
                case 'E':
                    Console.WriteLine("It is not good! You should study!");
                    break;
                case 'F':
                    Console.WriteLine("Fail! You need to repeat the exam!");
                    break; 
                default:
                    Console.WriteLine("Input is incorrect!");
                    break;             
            }


        }
    }
}    