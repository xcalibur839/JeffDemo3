using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Review last lesson and introduce new bool type
            int inputValue;
            bool isValid = true;

            Console.WriteLine("Enter a number");
            //Show the use of TryParse return value as condition
            if (int.TryParse(Console.ReadLine(), out inputValue))
            {
                //Show the ternary operator again
                Console.WriteLine($"That number is {(inputValue >= 0 ? "Positive" : "Negative")}");

                //Start with a single if, expand to else/if
                if (inputValue > 10)
                {
                    Console.WriteLine($"The number {inputValue} is also greater than 10");

                    //Move on to nested if once the concept is established
                    if (inputValue > 50)
                    {
                        Console.WriteLine("The number is also greater than 50");
                    }
                }
                else if (inputValue >= 5 && inputValue < 8)
                {
                    Console.WriteLine("The number is also between 4 and 8 (exclusive)");
                }

                //Show the effects of using or omitting code blocks
                else
                    Console.WriteLine("The number is not greater than 10");
            }
            else
            {
                isValid = false;
            }

            //Show the use of bool as a condition
            if (isValid)
            {
                Console.WriteLine("Attempting to use number as secret code...");

                //Compare with the switch statement. Show after nested ifs to help emphasize uses
                switch (inputValue)
                {
                    case 1122343456:
                        Console.WriteLine("30 Lives Code accepted");
                        break;
                    case 8675309:
                        Console.WriteLine("80s pop song mode activated");
                        break;
                    default:
                        Console.WriteLine("invalid code");
                        break;
                }
            }
            else
            {
                Console.WriteLine("invalid entry");
            }
            Console.ReadLine();
        }
    }
}
