using System;

public class Branching
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Please write the day");

        int day;
        if (!Int32.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
        {
            Console.WriteLine("Input is incorrect");
            return;
        }
        Console.WriteLine("Please write the month");
        int month;
        if (!Int32.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
        {
            Console.WriteLine("Input is incorrect");
            return;
        }
         Console.WriteLine("Please write the year");
        int year;
        if (!Int32.TryParse(Console.ReadLine(), out year) || year < 1)
        {
            Console.WriteLine("Input is incorrect");
            return;
        }
        Console.WriteLine("Please select the date formatting: enter 1 - YYYY/MM/DD, enter 2- YYYY.MM.DD");
        string selection = Console.ReadLine();
        switch (selection)
        {
           case "1" :
           Console.WriteLine(year + "/" + month + "/" + day);
           break;
           case "2" :
           Console.WriteLine(year + "." + month + "." + day);
           break;
           default :
           Console.WriteLine("Input is incorrect.Please write 1 or 2");
           break;
        }

    }

}