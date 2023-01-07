using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var counting = 0;

            for (int i =0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    counting = counting + numbers[i];
                }
                else
                {
                    counting = counting - numbers[i];
                }
            }
            return counting;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            int[] lengths = new int[4] { str1.Length, str2.Length, str3.Length, str4.Length };

            return lengths.Min();

            //string shortestString = str1;
            //int charCount = shortestString.Length;

            //if (str2.Length < str1.Length && str2.Length < str3.Length && str2.Length < str4.Length)
            //{
            //    shortestString = str2;
            //}
            //else if (str3.Length < str1.Length && str3.Length < str2.Length && str3.Length < str4.Length)
            //{
            //    shortestString = str3;
            //}
            //else if (str4.Length < str1.Length && str4.Length < str2.Length && str4.Length < str3.Length)
            //{
            //    shortestString = str4;
            //}
            //return charCount;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }
            else if (number2 <= number3 && number2 <= number4 && number2 <= number1)
            {
                return number2;
            }
            else if (number3 <= number4 && number3 <= number1 && number3 <= number2)
            {
                return number3;
            }
            else
                return number4;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3
             && sideLength1 + sideLength3 > sideLength2
             && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out double result))
            {
                return true;
            }  
            else
                return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var countElements = 0;
            var isNull = objs.Length;
            
            foreach (object val in objs)
            {
                if (val == null)
                    countElements++;
            }
            if (countElements > isNull / 2)
            {
                return true;

            }
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            double sumEvens = 0;
            int countEvens = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sumEvens += num;
                    countEvens++;
                }
            }
            if (countEvens == 0)
            {
                return 0;
            }
            return  (double)sumEvens / countEvens; // why does this need double 
        }

        public int Factorial(int number)
        {
            {
                if (number < 0) throw new ArgumentOutOfRangeException();
                if (number == 0) return 1;
                int result = 1;
                while (number != 1)
                {
                    result = result * number;
                    number = number - 1;
                }
                return result;
            }
        }
    }
}
            
            
            
           
