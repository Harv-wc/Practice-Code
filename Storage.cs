﻿using System;
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


     //
     //
     //##### STORAGE OF CLASSES #####
}
