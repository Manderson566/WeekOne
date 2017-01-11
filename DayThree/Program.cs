using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            string player = "Mic";
            int guess;

            while (playAgain)
            {
                Console.WriteLine($"{ player} Guess A Number");
                guess = int.Parse(Console.ReadLine());

                if (guess <= 5)
                {
                    playAgain = false;
                }
                else
                {
                    player = player == "Mic" ? "Bob" : "Mic";
                    {

                    }
                
                        Console.WriteLine($"{player}Lost!");
                    }
                }

            }

        }
    }

