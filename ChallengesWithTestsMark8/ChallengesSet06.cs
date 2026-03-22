using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                 return false;
            }

            if (word == null) 
            {
                return false;
            }

            foreach (string w in words)
            {
                if (w == null)
                {
                    continue;
                }
                if (ignoreCase)
                {
                    if (w.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                }
            else
            {
                if (w == word)
                {
                    return true;
                }
            }
        }
        return false; 
    }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }

            

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null)
            {
                return -1;
            }
            
            int lastIndex = - 1;

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    lastIndex = i;
                }
            }
            return lastIndex;
        } 
        

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int currentCount = 1;
            int maxCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[0];
            }
            List<double> result = new List<double>();

            for (int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % n == 0)
                {
                    result.Add(elements[i]);
                }
            }
            return result.ToArray();
        }
    }
}