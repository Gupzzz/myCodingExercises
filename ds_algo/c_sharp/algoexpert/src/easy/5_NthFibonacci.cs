namespace algoexpert
{
// ​Nth Fibonacci

// The Fibonacci sequence is defined as follows: the first number of the sequence is 0, 
// the second number is 1, and the nth number is the sum of the(n - 1)th and(n - 2)th numbers.
// Write a function that takes in an integer n and returns the nth Fibonacci number.

// Important note: the Fibonacci sequence is often defined with its first 2 numbers as F0 = 0 
// and F1 = 1.For the purpose of this question, the first Fibonacci number is F0; therefore, 
// getNthFib(1) is equal to F0, getNthFib(2) is equal to F1, etc..

// Sample input #1: 2
// Sample output #1: 1 (0, 1)
// Sample input #2: 6
// Sample output #2: 5 (0, 1, 1, 2, 3, 5)

public partial class Program
    {
        // O(n) time | O(1) space
        public static int GetNthFib(int n)
        {
            int[] lastTwo = { 0, 1 };
            int counter = 3;
            while (counter <= n)
            {
                int nextFib = lastTwo[0] + lastTwo[1];
                lastTwo[0] = lastTwo[1];
                lastTwo[1] = nextFib;
                counter++;
            }
            return n > 1 ? lastTwo[1] : lastTwo[0];
        }
    }
}