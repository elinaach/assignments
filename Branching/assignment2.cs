using System;

public class Branching
{
    public static void Main(string[] args)
    {
       int dayNumber;
        Console.WriteLine("Please enter the number of the day:");
        if (!Int32.TryParse(Console.ReadLine(), out dayNumber) || dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("Input is incorrect!");
            return;
        }
       
          switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("It is a working day");
                    break;
                case 2:
                    Console.WriteLine("It is a working day");
                    break;
                case 3:
                    Console.WriteLine("It is a working  day");
                    break;
                case 4:
                    Console.WriteLine("It is a working day");
                    break;
                case 5:
                    Console.WriteLine("It is a working day");
                    break;
                case 6:
                    Console.WriteLine("It is holiday");
                    break;
                case 7:
                    Console.WriteLine("It is holiday");
                    break;   
                default:
                    Console.WriteLine("Input is incorrect!!");
                    break;                         
            }
        

    }

}