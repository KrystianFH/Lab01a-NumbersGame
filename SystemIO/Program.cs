using System;
using System.IO;

namespace SystemIO
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           // Console.WriteLine(Challenge1());
           // Console.WriteLine(Challenge2());
           // Challenge5();
            Challenge6();



        }

        public static int Challenge1()
        {
            Console.WriteLine("Please enter three(3) numbers.");
            string input = Console.ReadLine();
            string[] numbers = input.Split(" ");
            int[] newArray = new int[numbers.Length];
          
            for (int i = 0; i < 3; i++)
            {
                bool canConvert = int.TryParse(numbers[i], out int num);
                if (canConvert == false)
                {
                    newArray[i] = 1;
                }
                else
                {
                    newArray[i] = num;
                }
            }
            return Multiply(newArray);
        }

        public static int Multiply(int[] arr)
        {
            if (arr.Length < 3)
            {
                return 0;
            }

            return arr[0] * arr[1] * arr[2];
        }
       
        // Challenge Two - Krystian & Scott
       // public static bool ValidateChallenge2(string input)
       // {
         //   return true;
       // }

       // public static int FindAverageChallenge2(int[] arr)
       // {
       //     return 0;
       // }


        // Challenge Five - Krystian & Matthew
        public static void Challenge5()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            FindMax(arr);
        }
        public static int FindMax(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > temp)
                {
                    temp = arr[i];
                }
            }
            Console.WriteLine(temp);
            return temp;
        }

        // Challenge 6 - Krystian and Alan

        public static void Challenge6()
        {
            Console.WriteLine("Please enter a word.");
            string input = Console.ReadLine() + "\n";

            string path = "../../../words.txt";
            File.AppendAllText(path, input);
            Challenge7(path);
           
        }

        // Challenge 7 - Krystian and Alan

        public static void Challenge7(string path)
        {
            Console.WriteLine(File.ReadAllText(path));
        }
    }
    
    
}
