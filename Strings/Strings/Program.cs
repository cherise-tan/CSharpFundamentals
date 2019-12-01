﻿using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            //Console.WriteLine("Enter a few numbers separated by a hyphen");
            //string userInput = Console.ReadLine();
            //var inputArray = userInput.Split("-");

            //var numberArray = new List<int>();

            //foreach (string input in inputArray)
            //{
            //    numberArray.Add(Convert.ToInt32(input));
            //}

            //var currentNumber = 0;

            //for (int i = 0; i < numberArray.Count; i++)
            //{
            //    if (numberArray[i] > currentNumber)
            //    {
            //        currentNumber = numberArray[i];

            //        if (i + 1 == numberArray.Count)
            //        {
            //            Console.WriteLine("Consecutive");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Consecutive");
            //        break;
            //    }
            //}


            // Exercise 2
            //Console.WriteLine("Enter a few numbers separated by a hyphen");
            //var userInput = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(userInput))
            //{
            //    return;
            //}

            //var numbers = new List<int>();
            //foreach(var number in userInput.Split("-")){
            //    numbers.Add(Convert.ToInt32(number));
            //}

            //var uniqueNumbers = new List<int>();
            //bool duplicates = false;

            //foreach(var number in numbers)
            //{
            //    if (uniqueNumbers.Contains(number))
            //    {
            //        duplicates = true;
            //        break;
            //    }
            //    else
            //    {
            //        uniqueNumbers.Add(number);
            //    }
            //}

            //if (duplicates)
            //{
            //    Console.WriteLine("Duplicate");
            //}


            // Exercise 3
            //bool validTime = false;

            //Console.WriteLine("Enter a time value in 24-hr time format - e.g. 19:00");

            //var userInput = Console.ReadLine();

            //if (!String.IsNullOrWhiteSpace(userInput))
            //{
            //    var convertedTime = new List<int>();
            //    foreach (var input in userInput.Split(":"))
            //    {
            //        convertedTime.Add(Convert.ToInt32(input));
            //    }

            //    int hours = convertedTime[0];
            //    int minutes = convertedTime[1];

            //    if (hours <= 23 && minutes <= 59)
            //    {
            //        validTime = true;
            //    }
            //}

            //if (validTime)
            //{
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Time");
            //}


            // Exercise 4
            //Console.WriteLine("Enter a few words separated by a space");
            //var words = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(words))
            //{
            //    return;
            //}

            //var result = "";
            //foreach(var word in words.Split(" "))
            //{
            //    var pascalCase = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();

            //    result += pascalCase;
            //}

            //Console.WriteLine(result);


            // Exercise 5
            Console.WriteLine("Please enter an english word");

            var input = Console.ReadLine().ToLower();

            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            var vowelCount = 0;

            foreach (var character in input)
            {
                if (vowels.Contains(character))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine(vowelCount);
        }
    }
}
