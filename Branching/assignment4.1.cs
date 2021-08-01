using System;

namespace Assignments
{
    class Branching
    {
        static void Main(string[] args)
        {
           double firstValue, secondValue;
           string action;

           Console.WriteLine ("Please enter value 1 ");
           firstValue = double.Parse(Console.ReadLine());
           
           Console.WriteLine ("Please enter value 2 ");
           secondValue = double.Parse(Console.ReadLine()); 
    //       try
    //       {
    //          Console.WriteLine ("Please enter value 1 ");
    //          firstValue = double.Parse(Console.ReadLine());
           
    //          Console.WriteLine ("Please enter value 2 ");
    //         secondValue = double.Parse(Console.ReadLine()); 
    //       }
    //       catch (Exception)
    //       {   
    //           Console.WriteLine ("Input is incorrect");
    //           Console.ReadLine();
    //       }

            Console.WriteLine ("Please choose option: '+' '-' '/' '*' '%' 'p'-print out both elements 'b'-verify which element is bigger 's'-verify which element is smaller");
            action = Console.ReadLine ();

           switch (action)
           {
               case "+":
                   Console.WriteLine (firstValue + secondValue);
                   break;
               case "-":
                   Console.WriteLine (firstValue - secondValue);
                   break;
               case "/":
                   if (secondValue == 0)
                       Console.WriteLine ("can't divide by zero");
                   else
                   Console.WriteLine (firstValue / secondValue);
                   break;
               case "*":
                   Console.WriteLine (firstValue * secondValue);
                   break;
               case "%":
                   Console.WriteLine (firstValue % secondValue);
                   break;
               case "p":
                   string str1 = firstValue.ToString();
                   string str2 = secondValue.ToString();
                   Console.WriteLine (str1 + " " + str2);
                   break;
               case "b":
                   Console.WriteLine (Math.Max(firstValue,secondValue));
                   break;
               case "s":
                   Console.WriteLine (Math.Min(firstValue,secondValue));
                   break;
               default:
                  Console.WriteLine ("Operation provided is incorrect");
                  break;
           }
        }
    }
}    