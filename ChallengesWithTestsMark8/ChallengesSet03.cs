using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Numerics;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {  
                return false; 
            }

            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false; 
            }

            int sum = 0;

            foreach (var item in numbers)
                if (item % 2 != 0)
                {
                    sum += item;
                }

            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return null != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0; 
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            return password.Any(char.IsUpper)
                && password.Any(char.IsLower)
                && password.Any(char.IsDigit);
        }


        public char GetFirstLetterOfString(string val)
        {
            return val[0]; 
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] myArray = new int[50];
            int index = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    myArray[index] = i;
                    index++;
                }
            }
            return myArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
      
    }
}
