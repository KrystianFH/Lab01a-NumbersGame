using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartSequence();

        }

        public static void StartSequence()
        {
            int numberEntered;
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math! Enter a number greater than zero.");
                numberEntered = Convert.ToInt32(Console.ReadLine());
                int[] numberEnteredArr = new int[numberEntered];
                
                Populate(numberEnteredArr);
                int numberSum = GetSum(numberEnteredArr);
                int numberProduct = GetProduct(numberEnteredArr, numberSum);
                decimal quotient = GetQuotient(numberProduct);
                Console.WriteLine($"Your array is size: {numberEntered}");
                Console.WriteLine($"The numbers in the array are: ");
                for (int i = 0; i < numberEnteredArr.Length; i++)
                {
                    Console.WriteLine($"{numberEnteredArr[i]}");
                }
                Console.WriteLine(" ");
                Console.WriteLine($"The sum of your array is: {numberSum}.");
                Console.WriteLine($"The product of {numberSum} and {numberProduct / numberSum} is: {numberProduct}");
                Console.WriteLine($"The quotient of {numberProduct} and {numberProduct / quotient} is: {quotient}");

            }
            catch (FormatException e)
            {
                Console.WriteLine("You must only use numbers");
                Console.WriteLine(e.Message);
                StartSequence();
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Yikes! That number was too big for me.");
                Console.WriteLine(oe.Message);
                StartSequence();
            }
        }

        public static int[] Populate(int[] numberEnteredArr)
        {
            for(int i = 0; i < numberEnteredArr.Length; i++)
            {
                Console.WriteLine($"Please enter a number: {i + 1} of {numberEnteredArr.Length}");
                string userInput = Console.ReadLine();
                numberEnteredArr[i] = Convert.ToInt32(userInput);
            }
            return numberEnteredArr;
        }

        public static int GetSum(int[] numberEnteredArr)
        {
            int numberSum = 0;

            for(int i = 0; i < numberEnteredArr.Length; i++)
            {
                numberSum += numberEnteredArr[i];
               
            }
            if (numberSum < 20)
            {
                throw new Exception($"Value of {numberSum} is too low");
            }
            return numberSum;
        }

        public static int GetProduct(int[] numberEnteredArray, int numberSum)
        {
            try
            {
                int size = numberEnteredArray.Length;
                Console.WriteLine($"Please enter a number between 1 and {size}");
                string userInput = Console.ReadLine();
                int numberProduct = numberSum * numberEnteredArray[Convert.ToInt32(userInput) - 1];

                return numberProduct;

            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine($"That number is not between 1 and {numberEnteredArray.Length}");
                Console.WriteLine(ie.Message);
                throw;
            }
        }

        public static decimal GetQuotient(int numberProduct)
        {
            try
            {
            Console.WriteLine($"Enter a number to divide into {numberProduct}.");
            string userInput = Console.ReadLine();
            decimal result = decimal.Divide(Convert.ToDecimal(numberProduct), Convert.ToDecimal(userInput));
            return result;
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("You cannot divide by zero silly");
                Console.WriteLine(de.Message);
                return 0;
                throw; 
            }

        }
        
    }
}
