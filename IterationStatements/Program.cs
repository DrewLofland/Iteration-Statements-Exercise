using System.Transactions;

namespace IterationStatements
{
    public class Program
    {
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Thousand();
            ByThree();
            IsEqual(5, 5);
            EvenOdd();
            PositiveNegative();
            CanYouVote();
            InRange();
            MultiplicationTable();
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable() 
        {
            
            int p;
            Console.WriteLine("Enter A Number");
            p = int.Parse(Console.ReadLine());
            for (int m = 1; m <= 12; m++)
            {
                Console.WriteLine($"{m} * {p} = {m * p}");   
            }
        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange() 
        {
            int num;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            if (num >= -10 && num <= 10)
            {
                Console.WriteLine($"The number is within range");
            }
            else
            {
                Console.WriteLine($"The number is not within range");
            }
        }




        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void CanYouVote() 
        {
            int age;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine($" You can vote!");
            }
            else
            {
                Console.WriteLine($"You cannot vote");
            }
        }


        //Write a method to check whether a given number is positive or negative
        public static void PositiveNegative() 
        {
            int z;
            Console.WriteLine("Enter a number to check positive or negative");
            z = int.Parse(Console.ReadLine());
            if (z > 0)
            {
                Console.WriteLine($"{z} is positive");
            }
            else 
            {
                Console.WriteLine($"{z} is negative");
            }

        }


        //Write a method to check whether a given number is even or odd
        public static void EvenOdd() 
        
        {   
            int n;
            Console.WriteLine("Enter a number to check even or odd");
            n = int.Parse(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine($"{n} is even");
            }
            else 
            {
                Console.WriteLine($"{n} is Odd");
            }
        }
        
        
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void IsEqual(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"equal");
            }
            else
            {
                Console.WriteLine($"not equal");
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThree() 
        { 
            for (int a = 3; a <= 999; a+= 3)
            {
                Console.WriteLine(a);
            }
        }

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Thousand() 
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        
        }
    }
}
