using System;

namespace Guess_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
                   
                bool areTriesOut = false; //variables
                int tries = 0;
                int win = 0;
                int levels = 1;
                int maxNumber = 100;
                int maxTries = 10;
                int triesLeft = 0;  
            
            Random randomNumber = new Random(); //random number
            int computerRandomNumber = randomNumber.Next(1, maxNumber + 1);
            Console.WriteLine($"Welcome to level {levels}.");
            
            while (!areTriesOut)//loop
            {              
                
                Console.WriteLine($"Guess a number (1-{maxNumber})"); //introducing to game level
                
                Console.ForegroundColor = ConsoleColor.Green;//player input
                string playerGuess = Console.ReadLine();
                if (playerGuess == "Tries")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    triesLeft = maxTries - tries;
                    Console.WriteLine($"You have {triesLeft} tries left!!!");
                    continue;
                }
                bool isValid = int.TryParse(playerGuess, out int playerNumber);
                Console.ForegroundColor = ConsoleColor.Blue;
                
                if (isValid) //game starts
                {
                    
                    if (playerNumber == computerRandomNumber) 
                    {
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("You win."); //win condition
                            win++;
                            Console.WriteLine("Do you want to go to the next level: [y]es, [n]o");                   
                        }
                        string playerInputRetry = (Console.ReadLine());
                        if (playerInputRetry == "y")  // if (playerInputRetry != "y" || playerInputRetry != "n")
                        {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"Welcome to level {++levels}...");
                                Console.WriteLine("Enjoy...");
                                maxNumber += 100;                             
                                computerRandomNumber = randomNumber.Next(1, maxNumber + 1);
                                tries = 0;
                                maxTries += 5;
                                continue;
                        }
                        else if (playerInputRetry == "n")  //exit condition
                        {
                            Console.WriteLine("See you next time...");
                            break;
                        }
                        else //exit condition
                        {
                            Console.WriteLine("Invalid input.");
                        }  
                    }
                    else if (playerNumber > computerRandomNumber)  //hints
                    {
                        Console.WriteLine("Too high. Go lower!!");
                        tries++;
                    }
                    else
                    {
                        Console.WriteLine("Too low. Go higher!!");
                        tries++;
                    }
                    if (tries == maxTries) //tries 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        tries = 0;
                        Console.WriteLine("You lose..... D:");
                        Console.WriteLine($"The number is: {computerRandomNumber} ");
                        Console.WriteLine("Do you want to play again?.... [y]es, [n]o");
                        string playerInput = (Console.ReadLine());
                        if (playerInput == "y")
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;    //Random randomRetryNumber = new Random(); int computerRetryNumber = randomRetryNumber.Next(1, maxNumber + 1);
                            Console.WriteLine("Enjoy...");
                            continue;
                        }
                        else if (playerInput == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"Wins: {win}");
                            Console.WriteLine("See you next time...");
                            areTriesOut = true;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }

                    }
                else 
                {
                    Console.WriteLine("Invalid input.");
                }
                
                }

            }

           





        }
    }
}
