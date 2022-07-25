using System;

namespace IEnumerableAndIEnumerator
{
    class Program
    {
        // 1.IEnumerable <T> for generic collections
        // 2.IEnumerable for non generic collections    

        /// <summary>
        ///  IEnumerable<T> contains a single method that you must implement when implementing this interface
        ///  GetEnumerator(), which returns an IEnumerator<T> object.
        ///  The returned IEnumerator<T> provides the ability to iterate through the collection
        ///  by exposing a Current property that points at the object we are currently at in the collection.
        /// </summary>

        /// <summary>
        /// When it is recommended to use the IEnumerable interface:
        /// Your collection represents a massive database table.
        /// You don't want to copy the entire thing into the memory and cause performance issues in your application.
        /// When it is nor recommended to use the IEnumerable interface:
        /// You need the results right away and are possibly mutating / editing the objects later on.
        /// In this case, is is better to use and Array or a List.
        /// </summary>

        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            foreach(Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }


            Console.ReadKey();
        }
    }
}
