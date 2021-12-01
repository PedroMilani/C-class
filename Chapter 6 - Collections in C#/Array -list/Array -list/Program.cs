using System;
using System.Collections;

namespace Array__list
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            // declaring an ArrayList with defined amount of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add("Deleted");
            myArrayList.Add(0.00023);
            myArrayList.Add("Pedro");
            myArrayList.Add(1993);
            myArrayList.Add(7);
            myArrayList.Add(10000000.000000001f);
            myArrayList.Add(400000.07);

            // delete element with specific value from the arraylist
            myArrayList.Remove(7);

            // delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is float)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
