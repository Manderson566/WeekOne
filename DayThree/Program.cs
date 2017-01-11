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
            string playAgain = "Y";
            while (playAgain == "Y")
            {
                Console.WriteLine("Play Again Y/N");
                playAgain = Console.ReadLine();
            }
        }
    
    }
}
