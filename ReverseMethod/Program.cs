using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*testArray is just to demonstrate that the alogrithm works.
             * If i really wanted to implement this i would have the user enter the array to be sorted.
             * I think my solution is quite sloppy. You probably have a neater more simpler way of doing this.
             */
            string[] testArray = new string[3] {"3","2","1"
            };
            Console.WriteLine(" New reversed array: ");
            foreach (string x in reverseArrayAlogrithm(testArray))
            {
                Console.Write(" "+ x + " ");
            }
            Console.ReadLine();

        }
        public static string[] reverseArrayAlogrithm(string[] toSortArray)
        {
            int backwardCounter = toSortArray.Length-1;
            int forwardCounter = 0;
            string temp = "";
            while(forwardCounter<=backwardCounter){
                temp = toSortArray[forwardCounter];
                toSortArray[forwardCounter] = toSortArray[backwardCounter];
                toSortArray[backwardCounter] = temp.ToString();
                backwardCounter -= 1;
                forwardCounter += 1;
            }
            return toSortArray;
        }
    }
}
