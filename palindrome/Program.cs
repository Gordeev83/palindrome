using static System.Runtime.InteropServices.JavaScript.JSType;

namespace palindrome
{
    class Program
    {
        static bool IsPalindrome(int number)
        {
            int reverse = 0;
            int original = number;

            while (number > 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }

            return original == reverse;
        }

        static void Main()
        {
            // Примеры вызова метода IsPalindrome
            Console.WriteLine(IsPalindrome(1221)); // true
            Console.WriteLine(IsPalindrome(3443));  // true
            Console.WriteLine(IsPalindrome(7854));  // false
        }
    }
}
