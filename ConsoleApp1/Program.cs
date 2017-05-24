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
            if (int.TryParse(Console.ReadLine(), out int num))
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
        public static void Exercise10()
        {
            Console.WriteLine("Enter a name");
            var names = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                else
                {
                    names.Add(input);
                }
                Console.WriteLine("Enter another name");
            }
            if (names.Count > 2)
            {
                var others = names.Count - 2;
                Console.WriteLine(names[0]+", "+names[1]+ " and "+others+" like your post"  );

            }
            else if (names.Count == 2)
            {
                Console.WriteLine(names[0]+ " and "+names[1]+" like your post");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine(names[0] + " likes your post");
            }
            
        }
        public static void Exercise11()
        {
            Console.WriteLine("Enter your name");
            var input = Console.ReadLine();
            var array = new char[input.Length];
            for (var i = input.Length; i >0; i--)
            {
                array[input.Length - i] = input[i - 1];
            }
            var reversed = new string(array);
            Console.WriteLine(reversed);
        }
        public static void Exercise12()
        {
            var numbers = new List<int>();
            while (numbers.Count < 6)
            {
                Console.WriteLine("enter a unique number");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("that's been done");
                }
                else
                {
                    numbers.Add(input);
                }
            }
            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
        public static void Exercise13()
        {
            var numbers = new List<int>();
            var unique = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number (or type Quit to exit)");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    var number = Convert.ToInt32(input);
                    if (!unique.Contains(number))
                    {
                        unique.Add(number);
                    }
                }
            }
            foreach (var num in unique)
            {
                Console.WriteLine(num);
            }
        }
        public static void Exercise14()
        {
            Console.WriteLine("Give me a list of 5 or more numbers separated by commas (no spaces)");
            var input = Console.ReadLine();
            var elements = input.Split(',');
            while  (elements.Length < 5)
            {
                Console.WriteLine("Invalid List, try again");
                input = Console.ReadLine();
                elements = input.Split(',');
            }
            var numbers = new List<int>(); 
            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
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
            Exercise10();
            Exercise11();
            Exercise12();
            Exercise13();
            Exercise14();
        }
    }
}
