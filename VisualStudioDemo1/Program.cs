using System;

namespace VisualStudioDemo1
{
    class Program
    {

        public static void Main(string[] args)
        {
            int[,] theArray = new int[2, 2];

            string userInput = "";

            do
            {
                DisplayArray(theArray);

                Console.Write("Please enter \"Exit\" to quit, or anything else to continue: ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() != "exit")
                {
                    int row, column, value;

                    Console.Write("Please enter a row number: ");
                    row = int.Parse(Console.ReadLine());

                    Console.Write("Please enter a column number: ");
                    column = int.Parse(Console.ReadLine());

                    Console.Write("Please enter a new value: ");
                    value = int.Parse(Console.ReadLine());

                    // Modify the array
                }
            } while (userInput.ToLower() != "exit");
        }

        static void DisplayArray(int[,] arrayToDisplay)
        {
            Console.WriteLine("-----");
            for (int r = 0; r < 2; r++)
            {
                Console.Write("|");
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(arrayToDisplay[c, r] + "|");
                }
                Console.WriteLine("\n-----");
            }
        }
    }
        }
