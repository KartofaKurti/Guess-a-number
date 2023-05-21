using System;

namespace Guess_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*next patch 
            1- colors
            2-tries counter showing to player 
            3-final level
            4- we will think about it
            */
            //variables
            bool areTriesOut = false;
            bool isLevelPassed = false;
            int tries = 0;
            int win = 0;
            int levels = 1;
            int maxNumber = 100;
            int maxTries = 10;
            //random number
            Random randomNumber = new Random();
            int computerRandomNumber = randomNumber.Next(1, maxNumber + 1);
            Console.WriteLine($"Welcome to level {levels}.");
            //loop
            while (!areTriesOut)
            {              
                //introducing to game level
                Console.WriteLine($"Guess a number (1-{maxNumber})");
                //player input
                string playerGuess = Console.ReadLine();    
                bool isValid = int.TryParse(playerGuess, out int playerNumber);
                //game starts
                if (isValid )
                {
                    tries++;
                    if (playerNumber == computerRandomNumber)
                    {
                        //win condition
                        Console.WriteLine("You win.");
                        win++;
                        Console.WriteLine("Do you want to go to the next level: [y]es, [n]o");
                        string playerInputRetry = (Console.ReadLine());
                        if (playerInputRetry == "y")
                        {
                                Console.WriteLine($"Welcome to level {++levels}");
                                Console.WriteLine("Enjoy");
                                maxNumber += 100;
                                computerRandomNumber = randomNumber.Next(1, maxNumber + 1);
                                tries = 0;
                                maxTries += 5;
                                continue;
                        }
                        //lose condition
                        else if (playerInputRetry == "n") 
                        {
                            Console.WriteLine("See you next time");
                            break;
                        }
                        //wrong input
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        
                    }//hints
                    else if (playerNumber > computerRandomNumber) 
                    {
                        Console.WriteLine("Too high.");                    
                    }
                    else
                    {
                        Console.WriteLine("Too low.");                  
                    }
                    //tries 
                    if (tries == maxTries)
                    {
                        tries = 0;
                        Console.WriteLine("You lose..... D:");
                        Console.WriteLine("Do you want to play again?.... [y]es, [n]o");
                        string playerInput = (Console.ReadLine());
                        if (playerInput == "y")
                        {
                            Console.WriteLine("Enjoy");
                            continue;
                            
                        }
                        else if (playerInput == "n")
                        {
                            Console.WriteLine("See you next time");
                            areTriesOut = true;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid input");
                }
                
            }
           





        }
    }
}
