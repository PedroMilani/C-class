using System;

namespace Challenge_datatype_and_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // INTEGER VARIABLES

            byte byte1 = 1; // .NET class Byte - unsigned integer from 0 to 255
            sbyte sbyte1 = -1; // .NET class SByte - signed integer from -128 to 127
            int int1 = 10; // .NET class Int32 - signed integer from -2,147,483,648 to 2,147,483,647
            uint uint1 = 1; // .NET class UInt32 - unsigned integer from 0 to 4294967295
            short short1 = -32000; // .NET class Int16 - signed integer from -32,768 to 32,767
            ushort ushort1 = 65000; // .NET class UInt16 - unsigned integer from 0 to 65535
            long long1 = -9909909999999; // .NET class Int64 - signed integer from -9223372036854775808 to 9223372036854775807
            ulong ulong1 = 1; // .NET class UInt64 - unsigned integer from 0 to 18446744073709551615

            // NON-INTEGER VARIABLES

            float float1 = 1.73447234f; // .NET class Single - Single-precision floating point type from -3.402823e38 to 3.402823e38
            double double1 = -2323612.23256; // .NET class Double - Double-precision floating point type from -3.402823e38 to 3.402823e38
            decimal decimal1 = 0.0000102030012045m; // .NET class Decimal - Precise fractional or integral type
                                                   // that can represent decimal numbers with 29 significant digits from ±1.0 × 10e−28 to ±7.9 × 10e28

            // OTHERS

            char char1 = '\''; // .NET class Char - A single unicode character used in text
            bool bool1 = true; // .NET class Boolean - Logical boolean type - True or False
            object object1 = bool1; // .NET class Object - Base type of all others type
            string string1 = "Pedro"; // .NET class string - A sequence of characters

            string firstString = "I control text";
            string secondString = "987654321";
            int convertedString = int.Parse(secondString);

            Console.WriteLine(firstString);
            Console.WriteLine(convertedString);


            Console.WriteLine(char1);
            Console.ReadKey();
        }
    }
}
