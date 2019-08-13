using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSquare DoMath = new SortedSquare { };
            int[] arr = new int[] { -9, -2, 0, 2, 3 };
            Console.WriteLine($"Original Array: {DoMath.ToStringAction(arr)}");
            Console.WriteLine($"Sorted Squared Array: {DoMath.ToStringAction(DoMath.SortArray(DoMath.SquareArray(arr)))}");




            // PAUSE //
            Console.ReadLine();
        }
       
    }
    
    class SortedSquare
    {
        public int[] SortArray(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                int temp = 0;
                for(int nextIndex = index+1; nextIndex < array.Length; nextIndex++)
                {
                    if(array[nextIndex]<array[index])
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
        public string ToStringAction(int[] array)
        {
            string asString = "";
            foreach(int num in array)
            {
                asString += (Convert.ToString(num) + " ");
            }
            return asString;
        }


    } //Given a sorted list of integers, square the elements and give the output in sorted order.

    
}