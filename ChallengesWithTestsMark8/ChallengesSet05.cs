using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n == 0)
            {
                throw new DivideByZeroException();
            }

            int currentNumber = startNumber + 1;

            while (currentNumber % n != 0)
            {
                currentNumber++;
            }
            return currentNumber;

            
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business == null)
                {
                    return; 
                }
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            if (numbers.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length -1; i++)
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0; 
            }
            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i+1];
                }
            }
            return sum;
        }
        
        public string TurnWordsIntoSentence(string[]words)
        {
            if (words == null)
            {
                return "";
            }
                
            string sentence = "";

            foreach (string word in words)
            {
                string clearWord = word.Trim();

                if(!string.IsNullOrWhiteSpace(clearWord))
                {
                    if (sentence.Length == 0)
                    {
                        sentence += clearWord.Substring(0,1).ToUpper()
                            + clearWord.Substring(1);
                    }

                    else
                    {
                        sentence += " ";
                        sentence += clearWord;
                    }
                    
                   
                }
            }
            
                if (sentence.Length > 0)
                {
                    sentence += ".";
                }
            
            return sentence;
            
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[0];
            }
            
            List<double> everyFourth = new List<double>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (i % 4 == 3)
                {
                    everyFourth.Add(elements[i]);
                }
            }
            
            return everyFourth.ToArray();
        }
        

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

          
            for (int i = 0; i < nums.Length ; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false; 
        }
    }
}