using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Environment
{
    class Storage
    {
        //##### STORAGE OF METHODS #####
        //
        //

        public void Menu()
        {
            // Change the number of menu items here
            const int quitVariable = 3;
            int selector = new int();
            bool userInput = false;
            int size = new int();

            while (selector != quitVariable)
            {
                Console.Clear();
                DrawMenu();
                userInput = int.TryParse(Console.ReadLine(), out selector);
                if (userInput)
                {
                    switch (selector)
                    {
                        case 1:
                            // EASY MODE
                            size = 8;
                            selector = 3;
                            break;
                        case 2:
                            //HARD MODE
                            size = 11;
                            selector = 3;
                            break;
                        case 3:
                            //QUIT GAME
                            userInput = false;
                            break;
                        //  If more cases, add here. If so, go to the top and change maxMenuItems amount the total cases 
                        default:
                            break;
                    }
                }
            }
            while (userInput == true)
            {
                // GAME HERE
                Console.WriteLine("Game plays");
                Console.ReadLine();
            }
        }
        private static void DrawMenu()
        {
            Console.WriteLine(" Welcome To STAR COLLECTOR ");
            Console.WriteLine("****************************");
            Console.WriteLine(" Select Your Difficulty ");
            Console.WriteLine("****************************");
            Console.WriteLine(" 1. REGULAR");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 2. HARD");
            Console.ResetColor();
            Console.WriteLine(" 3. Quit Game");
            Console.WriteLine("****************************");
        }
        public void SortedSquareMethod()
        {
            SortedSquare DoMath = new SortedSquare { };
            int[] arr = new int[] { -9, -2, 0, 2, 3 };
            Console.WriteLine($"Original Array: {DoMath.ToStringAction(arr)}");
            Console.WriteLine($"Sorted Squared Array: {DoMath.ToStringAction(DoMath.SortArray(DoMath.SquareArray(arr)))}");

            // PAUSE //
            Console.ReadLine();
        } // Method for the Sort and Square stuff
        public static int MaxProfit()
        {
            int[] stocks = { 9, 11, 8, 5, 7, 10, 1, 2, 3, 4 };
            int profit = 0;
            for (int i = 0; i < stocks.Length; i++)
            {
                for (int i2 = i + 1; i2 < stocks.Length; i2++)
                {
                    if ((stocks[i2] - stocks[i]) > profit)
                    {
                        profit = (stocks[i2] - stocks[i]);
                    }
                }
            }
            Console.WriteLine(profit);
            return profit;
        }// determine max profit attainable between one number and another after it
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"position {i}: {arr[i]}");
            }
        }
        private void LetterCount()
        {
            Console.Write("Enter a string to count the total number of characters: ");
            string inputString = Console.ReadLine().ToLower().Replace(" ", "");
            while (inputString.Length > 0)
            {
                int letterCount = (from letter in inputString where letter == inputString[0] select letter).Count();
                Console.WriteLine($"{inputString[0]} has: {letterCount} {inputString}");
                inputString = inputString.Replace($"{inputString[0]}", "");
            }
        }
        public void SortArray(int[] arr)
        {
            //int[] arr = { 7, 4, 1, 3, 8, 5 };
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                temp = arr[i];
                for (int i2 = i; i2 < arr.Length - 1; i2++)
                {
                    if (temp > arr[i2])
                    {
                        temp = arr[i2];
                    }
                }
                arr[i] = temp;
            }
        }
        public void VowelCountMethod()
        {
            string value = "aa ee ii oo uu yy dd";
            VowelCount MyWork = new VowelCount { };
            Console.WriteLine(MyWork.Counter(value));
        } // method for VowelCount

        /*
         * SmallestNonSum test = new SmallestNonSum { };
            int[] arr = { 1, 2, 3, 10 };
            Console.WriteLine(test.FindValue(arr, test.KnownSums(arr)));
         */

        //
        //
        //##### STORAGE OF METHODS #####
    }

    //##### STORAGE OF CLASSES #####
    //
    //

    class SortedSquare
    {
        public int[] SortArray(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                int temp;
                for (int nextIndex = index + 1; nextIndex < array.Length; nextIndex++)
                {
                    if (array[nextIndex] < array[index])
                    {
                        temp = array[index];
                        array[index] = array[nextIndex];
                        array[nextIndex] = temp;
                    }
                }
            }
            return array;
        }
        public int[] SquareArray(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = (array[index] * array[index]);
            }
            return array;
        }
        public string ToStringAction(int[] array) // still need to find a better way.... foreach(the stuff) Console.Write($"{num} ") -- I should start doing this instead.
        {
            string asString = "";
            foreach (int num in array)
            {
                asString += (Convert.ToString(num) + " ");
            }
            return asString;
        }
    } //Given a sorted list of integers, square the elements and give the output in sorted order.
    class VowelCount
    {
        public int Counter(string value)
        {
            int number = 0;
            string vowels = "aeiou";
            for (int i = 0; i < 5; i++)
            {
                foreach (char letter in value)
                {
                    if (vowels[0] == letter)
                        number++;
                }
                vowels = vowels.Replace($"{value[0]}", "");
            }
            return number;
        }
    }// go through a string and count the number of vowels
    class CountNumberOfOddNumbers
    {
        public int CountOddForSum(int value)
        {
            int sum = 0;
            int counter = 1;
            for (int i = 0; i < value; i++)
            {
                sum += counter;
                counter += 2;
            }
            return sum;
        }
    }// Write a method which takes an int X as input and returns the sum of the first X odd numbers. Given X = 4 Return 16 (1 + 3 + 5 + 7)
    class IntersectionStuff
    {
        private void intersecting()
        {

            List<int> p = new List<int>
            {
                1,
                3,
                5,
                7,
                6
            };
            List<int> q = new List<int>
            {
                2,
                4,
                6,
                3,
                7
            };
            int numOfIntersectingLines = 0;
            for (int i = 0; i < p.Count; i++)
            {
                for (int i2 = 0; i2 < p.Count; i2++)
                {
                    if (p[i] - q[i] != p[i2] - q[i2])
                    {
                        numOfIntersectingLines++;

                    }
                }
            }
            Console.WriteLine(numOfIntersectingLines);

        }

    } // incomp... Find the number of lines that intersect. Confine between y @ 0 -> 1...
    class PermutateArray
    {
        public object[] Permutate(int[] pArr, object[] inArr)
        {
            object[] newArr = new object[inArr.Length];

            for (int i = 0; i < inArr.Length; i++)
            {
                newArr[i] = inArr[pArr[i]];
            }

            return newArr;
        }
    }// re-order a given array of (anything) based on a given prmutation array.

    class RomanNumeral
    {
        /*Given a number in Roman Numeral format, convert it to a decimal. Assume that
         * only one smaller roman numeral can prefic a larger one.
         */

        public int RomanNumVal(char romanNum)
        {
            switch (romanNum)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 100;
                default:
                    return 0;
            }
        }
        public int RomanNumeralConversion(string input)
        {
            int numVal = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (i != 0 && RomanNumVal(input[i]) > RomanNumVal(input[i - 1]))
                {
                    numVal = numVal + (RomanNumVal(input[i]) - RomanNumVal(input[--i]));
                }
                else
                {
                    numVal = numVal + RomanNumVal(input[i]);
                }
            }
            return numVal;
        }
    }


    class SmallestNonSum
    {
        public List<int> KnownSums(int[] given)
        {
            List<int> storedValues = new List<int>();
            for (int i = 0; i < given.Length - 1; i++)
            {
                for (int i2 = i + 1; i2 < given.Length; i2++)
                {
                    storedValues.Add(given[i] + given[i2]);
                }
            }
            storedValues.Sort();
            return storedValues;
        }//does not find all subset sums. This method doesn't work well.
        public int FindValue(int[] given, List<int> known)
        {
            int max = given.Sum();
            int startNum = given[0];
            while (startNum <= max)
            {
                bool found = false;
                for (int i = 0; i < given.Length; i++)
                {
                    if (startNum == given[i] || known.Contains(startNum))
                    {
                        found = true;
                    }
                }
                if (found == false)
                {
                    return startNum;
                }
                startNum++;
            }
            return max + 1;
        }

    } // Given a sorted array, find the smallest positive integer that is not the sum of the subset of the array.


    /*class BigNum // handle interation beyond the 2bil int maxvalue. how?? long max = 9,223,372,036,854,775,807 // 9223372036854775807
    {

        public string Value { get; set; }

        public BigNum (string input)
        {
            this.Value = input;
        }
        public BigNum()
        {
            this.Value = "0";
        }
        public BigNum Add(BigNum input)
        {
            for()
        }

    }
    */


    //
    //
    //##### STORAGE OF CLASSES #####
}
