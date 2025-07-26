using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_keyword_demo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TOPIC:
            // return keyword in C#

            // DESCRIPTION:
            // It returns data back to the place ehere a method was called.

            try
            {
                Double ValueX;
                Double ValueY;
                Double Result;

                Console.Write("Enter Value X: ");
                ValueX = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Value Y: ");
                ValueY = Convert.ToDouble(Console.ReadLine());

                Multiply(ValueX, ValueY);

                Result = Multiply(ValueX, ValueY);
                Console.WriteLine($"{ValueX} * {ValueY} = {Result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        static Double Multiply(Double ValueX, Double ValueY)
        {
            try
            {
                Double ValueZ =  ValueX * ValueY;
                return ValueZ;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                return 0;
            }
        }
    }
}
