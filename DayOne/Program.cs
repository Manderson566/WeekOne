using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] addLines = {" ",
                                 " "};
            string[] board = {
                "_", "_", "_", "_", "_", "_", "_", "_", "_"
        };
            int counter = 0;
            foreach (string place in board)
                foreach(string line in addLines)
            {
                Console.Write(" " + place);
                if (counter == 2)
                {
                    Console.WriteLine (line);
                    counter = 0;
                }
                else
                {
                    counter++;
                }

            }
            var MyString = "Mic";
            var cleanString = MyString.Replace("i", "0");
            int classSize = int.Parse(Console.ReadLine());
            int[] ages = new int[classSize];

            for (int i = 0; i < classSize; i++)
            {
                Console.WriteLine($"Age of {i} student?");
                ages[i] = int.Parse(Console.ReadLine());

                if (i == 2)
                {
                    Console.WriteLine("Money Maker");
                }
                else if (i == 3)
                {
                    Console.WriteLine("Money Taker");
                }

            }
            foreach (var age in ages)
            {
                string readableDringAge;
                bool isLegalToDrink = age >= 21;
                if (isLegalToDrink)
                {
                    readableDringAge = "Yes";
                }
                else
                {
                    readableDringAge = "No";
                }

                readableDringAge = age >= 21 ? "Yes" : "No";
                Console.Write($"{age} is legal to drink?{readableDringAge}");
            }
            Console.WriteLine("--------");
            Console.WriteLine(ages.Max());
            Console.WriteLine(ages.Min());
            Console.WriteLine(ages.Average());



            string[] myArray = new string[9];
            myArray[0] = "X";

            Console.WriteLine(myArray);
        }
    }
}
