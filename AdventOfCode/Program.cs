using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayOnePartOne());
            Console.ReadKey();
            Console.WriteLine(DayOnePartTwo());
            Console.ReadKey();
        }

        static int DayOnePartOne()
        {
            string input;
            List<int> inputs = new List<int>();
            int counter = 0;
            int prevNumber;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\DarrenNicholas\Documents\Day1.txt");
            int startingPoint = int.Parse(file.ReadLine());
            prevNumber = startingPoint;

            while((input = file.ReadLine()) != null)
            {
                inputs.Add(int.Parse(input));
            }
            
            foreach(var number in inputs)
            {
                if(number > prevNumber)
                {
                    counter ++;
                }
                prevNumber = number;
            }

            return counter;
        }

        static int DayOnePartTwo()
        {
            string input;
            List<int> inputs = new List<int>();
            int counter = 0;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\DarrenNicholas\Documents\Day1.txt");

            while ((input = file.ReadLine()) != null)
            {
                inputs.Add(int.Parse(input));
            }

            int startingSumPoint = 0;
            int prevSum = inputs[0] + inputs[1] + inputs[2];

            foreach (var number in inputs)
            {
                if (number == inputs[^1] || number == inputs[^2]) continue;
                int sum = inputs[startingSumPoint] + inputs[startingSumPoint + 1] + inputs[startingSumPoint + 2];
                if(sum > prevSum)
                {
                    counter++;
                }
                startingSumPoint++;
                prevSum = sum;
            }

            return counter;
        }
    }
}
