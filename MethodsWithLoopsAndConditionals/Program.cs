using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that will print to the console all numbers 1000 through - 1000
            PrintThousand();
            PrintNumbers();
            CheckingParameters(2, 4);
            EvenOrOdd();
            PositiveOrNegative();
            
        }
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
            Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintNumbers()
        {
            for (int i = 3; i <=999; i +=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool CheckingParameters(int x, int y)
        {
            if (x == y)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
            //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number");
            var num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("Even!");
            
            }

            else
            {
                Console.WriteLine("False!");
            }
        }

           
            //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative()
        {
            var num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive!");
            }
  
            else
            {
                Console.WriteLine("Negative!");
            }
            
        }

        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void VotingAge()
        {
            Console.WriteLine("Input your age");
            var x = int.Parse(Console.ReadLine());

            if (x >= 18)
            {

                Console.WriteLine("You can vote!");
            }

            else

            {
                Console.WriteLine("You're too young to vote!");
            }

        }
        
      
    }
}




