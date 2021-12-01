using System;

namespace Array_as_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] studentsGrades = new double[] { 9, 8.5, 8, 7.9, 8.4, 5, 6.5, 6 };
            double averageResult = GetAvarage(studentsGrades);

            foreach(double grade in studentsGrades)
            {
                Console.WriteLine("{0}", grade);
            }

            Console.WriteLine("The avarage is: {0}", averageResult);
            Console.ReadKey();
        }

        static double GetAvarage(double[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            double sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = sum / size;
            return average;
        }
    }
}
