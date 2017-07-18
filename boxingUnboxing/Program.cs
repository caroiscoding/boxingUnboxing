using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /// create an empty list of type object
            List<object> myList = new List<object>();

            /// add 7,28,-1 true, "chair" to the list
            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");

            ///loop  throught the list, disolay all values and add all those that are tyoe interface int
            int sum = 0;
            foreach(var obj in myList){
                Console.WriteLine(obj);
                if(obj is int){
                    sum += (int)obj;
                }
            }
            Console.WriteLine("the sum of all the integers in the list {0}", sum);
        }
    }
}
