using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }
        public bool CountOfElementsIsEven(string[] vals)
        {
                return vals.Length % 2 == 0;
        }      
           
        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }

        public bool IsNumberOdd(int num)
        {
           return num% 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if ( numbers == null || numbers.Count() == 0 )
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
                
        }

        public int SumEvens(int[] numbers)
        {
            int sumOfEvens = 0;
            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvens += numbers[i];
                }
                
            }
            return sumOfEvens;
        }

        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }
            else 
            {
                return (numbers.Sum() % 2 != 0); ;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            while (number > 0)
            {
                int count = 0;
                for (int i = 1; i < number; i += 2)
                {
                    count++;
                }
                return count;
            }
            return 0;
        }
    }
}
