using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);
            int count = 0;

            while (true)
            {
                Console.Write("Guess a number (1 - 101): ");
                string playerInput = Console.ReadLine();
                count++;
                bool isValid = int.TryParse(playerInput, out int playerNumber);


                if (isValid)
                {
                    if (count == 4)
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}