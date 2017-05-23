using System;
using System.Numerics;
using System.Collections.Generic;

namespace CSharpBeginner
{
    class Program
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number <= 10 && number > 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public static void Exercise2()
        {
            Console.WriteLine("Give me 2 numbers please");
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            var num1 = Convert.ToInt32(input1);
            var num2 = Convert.ToInt32(input2);
            if (num1 > num2)
            {
                Console.WriteLine(input1 + " is bigger");
            }
            else if (num1 < num2)
            {
                Console.WriteLine(input2 + " is bigger");
            }
            else
            {
                Console.WriteLine("They are equal");
            }
        }
        public static void Exercise3()
        {
            Console.WriteLine("Enter the height of your image");
            var h = Console.ReadLine();
            Console.WriteLine("Enter the width of your image");
            var w = Console.ReadLine();
            var width = Convert.ToInt32(w);
            var height = Convert.ToInt32(h);
            if (height >= width)
            {
                Console.WriteLine("It's portrait");
            }
            else
            {
                Console.WriteLine("It's Landscape");
            }
        }
        public static void Exercise4()
        {
            Console.WriteLine("What's the speed limit");
            var input = Console.ReadLine();
            var limit = Convert.ToInt32(input);
            Console.WriteLine("How fast did the car go");
            var input2 = Console.ReadLine();
            var speed = Convert.ToInt32(input2);
            if (speed > limit)
            {
                var demerits = Math.Floor((speed - limit) / 5d);
                if (demerits > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("issue " + demerits+ " demerits");
                }
            }
        }
        public static void Exercise5()
        {
            var counter = 0;
            for(var i = 1; i<100;i++)
            {
                if (i%3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        public static void Exercise6()
        {
            var num = 0;
            while (true)
            {
                Console.WriteLine("enter a number, or enter OK to exit");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }
                else if (int.TryParse(input, out int value))
                {
                    num += Convert.ToInt32(value);
                }
                else
                {
                    Console.WriteLine(" ¯\\_(ツ)_/¯ ");
                }

            }
            Console.WriteLine(num);
        }
        public static void Exercise7()
        {
            Console.WriteLine("what's the factorial?");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                BigInteger sum = num;
                while (num > 1)
                {
                    sum *= num - 1;
                    num--;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Sorry, that wasn't a number");
            }
        }
        public static void Exercise8()
        {
            var secret = new Random().Next(1, 10);
            Console.WriteLine("secret is "+secret);
            var guesses = 0;
            while (guesses < 4)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                var guess = Console.ReadLine();
                if (int.TryParse(guess, out int number))
                {
                    if (number == secret)
                    {
                        Console.WriteLine("You won!");
                        return;
                    }
                    else
                    {
                        guesses++;
                        Console.WriteLine("Incorrect");
                    }
                }
                else
                {
                    Console.WriteLine("sorry, that wasn't a number");
                }
            }
            Console.WriteLine("you lost!");
        }
        public static void Exercise9()
        {
            Console.WriteLine("give me a list of numbers separated by commas (no spaces)");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);
            foreach (var number in numbers)
            {
                var test = Convert.ToInt32(number);
                if (max < test)
                {
                    max = test;
                }
            }
            Console.WriteLine("The largest one was " + max);
        }
        public static void Test()
        {
            var numbners = new List<int>();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            Exercise6();
            Exercise7();
            Exercise8();
            Exercise9();

        }
    }
}
