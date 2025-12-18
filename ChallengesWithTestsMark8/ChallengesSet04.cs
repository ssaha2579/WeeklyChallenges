using System;
using System.Linq; // Needed for LINQ methods like Where, Min, Average                
using System.Collections.Generic; // Needed for List<T>
using System.ComponentModel.Design;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers) // Add evens, subtract odds                 
        {
            return numbers.Where(x => x % 2 == 0).Sum() // Sum of even numbers  
                   - numbers.Where(x => x % 2 != 0).Sum(); // Subtract sum of odd numbers
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3,
            string str4) // Shortest string length
        {
            var lengths = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length }; //Store lengths
            return lengths.Min(); // Return minimum length
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4) // Smallest number  
        {
            var numbers = new List<int> { number1, number2, number3, number4 }; // stores numbwers         
            return numbers.Min(); // Return smallest  
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz) // Rename busines
        {
            biz.Name = "TrueCoders"; //Change name directly 
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3) //Triange Check
        {
            return sideLength1 + sideLength2 > sideLength3 && //Sum of any two sides > third side 
                   sideLength1 + sideLength3 > sideLength2 &&
                   sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input) // Check if string can be parsed to number
        {
            return double.TryParse(input, out double number); // Returns true if parse succeeds
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs) // Check if majority are null      
        {
            if (objs == null || objs.Length == 0) // Return false if array is null or empty
                return false;


            int nullCount = 0; // Counter for nulls

            foreach (var obj in objs) // Loop through each element

            {
                if (obj == null) nullCount++; // Increment counter if element is null
            }

            return nullCount > objs.Length / 2; // Return true if nulls are majority
        }

        public double AverageEvens(int[] numbers) // Average of even numbers
        {
            return numbers? // If numbers is null, continue safely
                .Where(x => x % 2 == 0) //  Keep only the even numbers
                .DefaultIfEmpty(0) // If no even numbers, use 0 to avoid errors   
                .Average() ?? 0; // Compute average; if numbers was null, return 0
        }

        public int Factorial(int number)
        {
            if (number < 0) // Negative input check
                throw new ArgumentOutOfRangeException(nameof(number), "number cannot be negative");


            if (number == 0 || number == 1) // Base cases
                return 1;

            return number * Factorial(number - 1); // Recursive call
        }
    }
}