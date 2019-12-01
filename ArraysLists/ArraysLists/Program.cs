using System;
using System.Collections.Generic;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {

            // EXERCISE 1:
            //var friends = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("Enter a name");
            //    var newFriend = Console.ReadLine();                

            //    if (String.IsNullOrWhiteSpace(newFriend))
            //    {
            //        break;
            //    }

            //    friends.Add(newFriend);

            //    if (friends.Count == 1)
            //    {
            //        Console.WriteLine(friends[0] + " likes your post");
            //    }
            //    else if (friends.Count == 2)
            //    {
            //        Console.WriteLine(String.Format("{0} and {1} like your post", friends[0], friends[1]));
            //    }
            //    else
            //    {
            //        Console.WriteLine(String.Format("{0}, {1} and {2} others like your post", friends[0], friends[2], friends.Count - 2));
            //    }              
            //}

            // EXERCISE 2
            //Console.WriteLine("Please enter your name");
            //var input = Console.ReadLine();

            //var inputArray = input.ToCharArray();

            //Array.Reverse(inputArray);

            //var reversed = new string(inputArray);

            //Console.WriteLine(reversed);'


            // EXERCISE 3
            //var numbers = new List<int>();

            //while (numbers.Count < 5)
            //{
            //    Console.WriteLine("Please enter a number");

            //    var newNumber = Convert.ToInt32(Console.ReadLine());

            //    if (numbers.Contains(newNumber))
            //    {
            //        Console.WriteLine("Please add a unique number");
            //    }
            //    else
            //    {
            //        numbers.Add(newNumber);
            //    }
            //}

            //numbers.Sort();

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            // EXERCISE 4
            //var numbers = new List<int>();

            //while (true)
            //{
            //    Console.WriteLine("Please enter a number or type quit to exit");

            //    var input = Console.ReadLine();

            //    if (input == "quit")
            //    {
            //        break;
            //    }

            //    var newNumber = Convert.ToInt32(input);
            //    numbers.Add(newNumber);                           

            //}

            //var uniqueNumbers = new List<int>();

            //for (var i = 0; i < numbers.Count; i++)
            //{
            //    if (!uniqueNumbers.Contains(numbers[i]))
            //    {
            //        uniqueNumbers.Add(numbers[i]);
            //    }
            //}

            //Console.WriteLine("Number of unique numbers: " + uniqueNumbers.Count);


            // EXERCISE 5
            string[] inputs;

            Console.WriteLine("Supply a list of comma separated numbers");

            while (true)
            {
                var input = Console.ReadLine();               


                if (!String.IsNullOrWhiteSpace(input))
                {
                    inputs = input.Split(",");

                    if (inputs.Length >= 5)
                    {
                        break;
                    }                      
                }

                Console.WriteLine("Invalid List - please try again");
            }

            var numbers = new List<int>();
            foreach(var input in inputs)
            {
                numbers.Add(Convert.ToInt32(input));
            }

            numbers.Sort();

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
