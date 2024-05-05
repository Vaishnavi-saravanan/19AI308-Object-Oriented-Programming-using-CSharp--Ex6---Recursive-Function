using System;
namespace program11{
    class Program
    {
        static int ReverseNumber(int num, int reversedNum = 0)
        {
            // Base case: if the number becomes 0, return the reversed number
            if (num == 0)
                return reversedNum;
            
            // Extract the last digit of the number
            int lastDigit = num % 10;
            
            // Add the last digit to the reversed number
            reversedNum = reversedNum * 10 + lastDigit;
            
            // Recursively call ReverseNumber with the remaining digits
            return ReverseNumber(num / 10, reversedNum);
        }
    
        static void Main(string[] args)
        {
            // Input the number to be reversed
            Console.Write("Enter a number to reverse: ");
            int number = Convert.ToInt32(Console.ReadLine());
    
            // Call the ReverseNumber function and print the reversed number
            int reversedNumber = ReverseNumber(number);
            Console.WriteLine("Reversed Number: " + reversedNumber);
        }
    }
}
