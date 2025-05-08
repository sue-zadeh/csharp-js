int[] numbers = {1, 2, 3};         // array of integers
string[] names = {"Sue", "Ali"};   // array of strings
bool[] flags = {true, false};      // array of booleans
double[] grades = {1.5, 2.3};      // array of doubles (decimal numbers)
char[] letters = {'a', 'b', 'c'};  // array of characters

 string s = "hello";
Console.WriteLine(s.Length);
Console.WriteLine(s.Substring(1, 2));  // "el"
Console.WriteLine(s.Contains("he"));  // true




using System; // gives access to Console.WriteLine, Math, etc. 
// so it tells C# we want to use Console.WriteLine and other built-in tools:
//  if you want to use basic things like:
// Console.WriteLine()
// Math functions
// Date and time

using System.Collections.Generic; // gives access to List<T> and other collection types, 
// this one is needed only if we want to use List<>

class Program // this is the main class
{
    
    // This is where the program starts running
    static void Main() // main function, like JavaScript's starting point
// static = means it can run without making an object
// void = means it doesn’t return anything
// Main = is the name C# looks for to start the program
    {
        List<int> numbers = new List<int> { 3, 6, 7, 2, 9, 10 }; // your list of numbers

        foreach (int num in numbers) // goes through each number in the list
        {
            if (num % 2 == 0) // check if it's even
            {
                Console.WriteLine(num); // print it
            }
        }
    }
}

// add 'r' at the end of each key in the array:

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> myStr = new List<string> { "fi", "fe", "fo" };

        foreach (string s in myStr)
        {
            string result = s + "r";
            Console.WriteLine(result);  // prints fir, fer, for
        }
    }
}

//Problem:
// Write a function that receives a list of numbers and returns the sum of all even numbers.

// 📝 Example:
// Input: [3, 6, 7, 2, 9, 10]
// Even numbers: 6, 2, 10
// Output: 18

// ✍️ 1. Pseudocode (your thinking plan)
// sql
// Copy
// Edit
// Start
//   Set sum = 0
//   For each number in the list:
//     If number is even (number % 2 == 0):
//       Add it to sum
//   Return sum
// End
using System;
using Sytem.Collections.Generic;
class Program{
  static int SumOfEven(List<int>numbers)
  {
    int sum=0;
    foreach (int num in mumbers) {
      if (num%2 == 0) {
        sum+= num;        
      }
    }
    return sum;
  }
  static void main ()
  {
    List<int> myNumbers = new List<int> {3.4.5.6.7.8};
    int result = SumOfEven(myNumbers);
    Console.WriteLine(sbyte"sum of even numbers:"+ result);
  }
}
