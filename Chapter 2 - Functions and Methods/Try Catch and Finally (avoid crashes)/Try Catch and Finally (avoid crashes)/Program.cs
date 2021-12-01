using System;

namespace Try_Catch_and_Finally__avoid_crashes_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers to be divided.");
            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();

            try
            {
                int userInputAsInt1 = int.Parse(userInput1);
                int userInputAsInt2 = int.Parse(userInput2);
                Divide(userInputAsInt1, userInputAsInt2);
            }

            catch(FormatException) // Whenever the try method goes wrong the catch will be executed
            {
                
                // throw;
                // with the trow command you can know the type of exception occured

                Console.WriteLine("Format exception, enter the correct type asked.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number is too short or too long for an Int32.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument null exception, the value was empty (null).");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero exception, the divisor number must not be 0");
            }
            catch (Exception)
            {
                //throw;
                Console.WriteLine("General exception");
            }

            finally
            {
                Console.WriteLine("This is called anyways!");
            }
            
            Console.ReadKey();
        }

        public static double Divide(int numb1, int numb2)
        {
            double DivideResult = numb1 / numb2;
            return DivideResult;
        }
    }
}
