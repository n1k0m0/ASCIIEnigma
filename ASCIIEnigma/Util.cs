/*
   Copyright 2022 Nils Kopal, CrypTool project

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System;
using System.Linq;
using System.Text;

namespace ASCIIEnigma
{
    /// <summary>
    /// Static class with some helper functions and some extensions
    /// for string and int array
    /// </summary>
    public static class Util
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Computes mathematical modulo operation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Mod(int a, int n)
        {
            return ((a % n) + n) % n;
        }

        /// <summary>
        /// Converts the array to a comma separated string of int values
        /// </summary>
        /// <returns></returns>
        public static string ToIntString(this int[] numbers)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                builder.Append(numbers[i].ToString());
                if (i != numbers.Length - 1)
                {
                    builder.Append(", ");
                }
            }
            return builder.ToString();
        }

        /// <summary>
        /// Converts the array to a string by using the integers as char values
        /// </summary>
        /// <returns></returns>
        public static string GetString(this int[] numbers)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                builder.Append((char)numbers[i]);
            }
            return builder.ToString();
        }

        /// <summary>
        /// Converts the string to an integer array using the char values
        /// </summary>
        /// <returns></returns>
        public static int[] ToIntArray(this string str)
        {
            int[] integers = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                integers[i] = Mod(str[i], 256);
            }

            return integers;
        }

        /// <summary>
        /// Maps a given array of numbers into the "textspace" defined by the alphabet
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        public static string MapNumbersIntoTextSpace(int[] numbers, string alphabet)
        {
            StringBuilder builder = new StringBuilder();
            foreach (int i in numbers)
            {
                builder.Append(alphabet[i]);
            }
            return builder.ToString();
        }

        /// <summary>
        /// Maps a given string into the "numberspace" defined by the alphabet
        /// </summary>
        /// <param name="text"></param>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        public static int[] MapTextIntoNumberSpace(string text, string alphabet)
        {
            int[] numbers = new int[text.Length];
            int position = 0;
            foreach (char c in text)
            {
                numbers[position] = alphabet.IndexOf(c);
                position++;
            }
            return numbers;
        }

        /// <summary>
        /// Extension for string: Removes all chars from the string which are not part of the alphabet
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        public static string RemoveInvalidChars(this string text, string alphabet)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char c in text)
            {
                if (alphabet.Contains(c))
                {
                    builder.Append(c);
                }
            }
            return builder.ToString();
        }

        /// <summary>
        /// Extension for int array: Returns index of the element in the integer array. If element is not in the array, it returns -1
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int IndexOf(this int[] array, int element)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == element)
                {
                    return index;
                }
            }
            return -1;
        }

        /// <summary>
        /// Extension for int array: Shuffles the integer array
        /// </summary>
        /// <returns></returns>
        public static int[] Shuffle(this int[] array)
        {
            int[] newArray = (int[])array.Clone();
            for (int i = 0; i < array.Length; i++)
            {
                int randomPosition = _random.Next(0, newArray.Length - 1);
                object swap = newArray.GetValue(i);
                newArray.SetValue(newArray.GetValue(randomPosition), i);
                newArray.SetValue(swap, randomPosition);
            }
            return newArray;
        }

        /// <summary>
        /// Extension for int array: Returns true, if given element is in the integer array
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool Contains(this int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Extension for int array: Returns the reversed integer array
        /// </summary>
        /// <returns></returns>
        public static int[] Reverse(this int[] array)
        {
            int[] newarray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newarray[i] = array[array.Length - i - 1];
            }
            return newarray;
        }
    }
}
