using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //var count = 0;

            //for (var i = 1; i<= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);


            //var sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number or type ok to exit");
            //    var input = Console.ReadLine();

            //    if (input == "ok")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        sum += Convert.ToInt32(input);
            //    }
            //}
            //Console.WriteLine(sum);


            //Console.WriteLine("Please enter a number");
            //var number = Convert.ToInt32(Console.ReadLine());

            //var factorial = 1;

            //for (var i = 1; i <= number; i++)
            //{
            //    factorial *= i;
            //}

            //Console.WriteLine(factorial);


            //var randomNumber = new Random().Next(1, 10);
            //Console.WriteLine(randomNumber);

            //Console.WriteLine("Guess the number");

            //for (var i = 1; i <= 4; i++)
            //{

            //    var guessedNumber = Convert.ToInt32(Console.ReadLine());

            //    if (guessedNumber == randomNumber)
            //    {
            //        Console.WriteLine("You won");
            //        return;
            //    }
            //}

            //Console.WriteLine("You lost");


            Console.WriteLine("Enter a series of comma-separated numbers");

            var input = Console.ReadLine();

            var inputArray = input.Split(",");

            var max = Convert.ToInt32(inputArray[0]);

            for (var i = 1; i < inputArray.Length; i++)
            {
                if (Convert.ToInt32(inputArray[i]) > max)
                {
                    max = Convert.ToInt32(inputArray[i]);
                }
            }

            Console.WriteLine(max);
        }
    }
}
