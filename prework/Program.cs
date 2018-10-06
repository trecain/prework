using System;

namespace prework
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayMaxResults();
            LeapYearCalculator();
            PerfectSequenceStart();
            SumOfRows();
            Console.ReadLine();
        }

        //Problem 1: Array Max Result

        static void ArrayMaxResults()
        {
            int[] arrayOfFiveNumbers = new int[5];
            Console.WriteLine("Welcome to Array Max, please follow the prompt to select your array.");
            for ( int i = 0; i < arrayOfFiveNumbers.Length; i++)
            {
                arrayOfFiveNumbers[i] = RandomlyGeneratedNumberArray();
            }
            Console.WriteLine($"Please pick a number from: [{string.Join(", ", arrayOfFiveNumbers)}]");
            int userPickedNumberFromArray = Convert.ToInt32(Console.ReadLine());

            int resultsNumber;
            int[] matchingNumbersArray = Array.FindAll(arrayOfFiveNumbers, el => el == userPickedNumberFromArray);
            resultsNumber = userPickedNumberFromArray * matchingNumbersArray.Length;
            Console.WriteLine($"The output is {resultsNumber}");
        }

        static int RandomlyGeneratedNumberArray()
        {
            Console.WriteLine("Choose a number between 1 and 10 please...");
            int usersNumber = Convert.ToInt32(Console.ReadLine());

            while (usersNumber < 1 || usersNumber > 10)
            {
                Console.WriteLine("The number entered isn't between 1 and 10...");
                usersNumber = Convert.ToInt32(Console.ReadLine());
            }
            return usersNumber;
        }

        //Problem 2: Leap Year Calculator

        static string LeapYearCalculator()
        {
            Console.WriteLine("Please input a year to check if it's Leap!!!");
            int yearChosenByUser = Convert.ToInt32(Console.ReadLine());
            string response;
            if (yearChosenByUser % 4 == 0)
                if (yearChosenByUser % 100 == 0)
                    if (yearChosenByUser % 400 == 0)
                        response = $"The {yearChosenByUser} fell on a leap year!!!";
                    else
                        response = $"The {yearChosenByUser} does not fall on a leap year!!!";
                else
                    response = $"The {yearChosenByUser} does fall on a leap year!!!";
            else
                response = $"The {yearChosenByUser} does not fall on a leap year!!!";

            Console.WriteLine(response);
            return response;
        }

        //Problem 3: Perfect Sequence

        static void PerfectSequenceStart()
        {
            int[] userSeq = new int[] {1,3,2};
            Console.WriteLine(PerfectSequenceStart(userSeq));
            Console.ReadLine();
        }

        static string PerfectSequenceStart(int[] seq)
        {
            Console.WriteLine($"Is [{string.Join(", ", seq)}] is a perfect sequence?");
            int sum = 0;
            int prod = 1; 
            foreach (int num in seq)
            {
                sum += num;
                prod *= num;
            }

            if (Array.Exists(seq, el => el > 0) && sum == prod)
                return "You're correct";
            else
                return "You're incorrect";
        }

        //Problem 4: Sum of Rows

        static void SumOfRows()
        {
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            Console.WriteLine("The array inputted is: { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } }");
            int[] arrSum = new int[myArray.GetLength(0)];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    arrSum[i] += myArray[i, j];
                }
            }
            Console.WriteLine($"The sum of the rows is: [{string.Join(", ", arrSum)}]");
        }
    }
}
