using System;
using System.Collections.Generic;

namespace listExamplesAndPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5};
            //Add
            numbers.Add(1);//Added to end
            numbers.AddRange(new int[3] {5, 6, 7});//Added to end.

            foreach (var number in numbers)
            {
                Console.WriteLine(number);   
            }

            //index
            Console.WriteLine();
            Console.WriteLine(numbers.IndexOf(4));//from beginning
            Console.WriteLine(numbers.LastIndexOf(4));//last occurance
            //count
            Console.WriteLine(numbers.Count);
            //remove
            numbers.Remove(1);

            //remove all occurances
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Clear();
            Console.WriteLine("count: "  + numbers.Count);
           


        }
    }
}
