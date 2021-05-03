using System;
using System.IO;

namespace CalculatorApp
{
    class Program: Calculators
    {
        static string appTitle = "Conosle Calculator in C#";
        static string typeMessage = "Type a number, and press Enter";
        static string outputMessage = "Your result:";

        static double readInput(int count)
        {
            double returnValue;

            try
            {
                Console.WriteLine($"{count} {typeMessage}:");

                returnValue = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                returnValue = -999999999;
            }

            return returnValue;
        }

        static void opertaion(double num1, double num2, string op) {
            Writer writer = new Writer();

            switch (op)
            {
                case "a":
                    writer.Log($"{outputMessage} {num1} + {num2} = {adition(num1, num2)}.");
                    break;
                case "s":
                    writer.Log($"{outputMessage} {num1} - {num2} = {subtraction(num1, num2)}.");
                    break;
                case "m":
                    writer.Log($"{outputMessage} {num1} * {num2} = {multiply(num1, num2)}.");
                    break;
                case "d":
                    if (num2 < 1)
                    {
                        num2 = readInput(2);
                        writer.BlankLine();
                    }
                    writer.Log($"{outputMessage} {num1} / {num2} = {divide(num1, num2)}.");
                    break;
                default:
                    writer.Log("Invalid Operation.");
                    opertaion(num1, num2, op);
                    break;
            }

            writer.BlankLine();
            writer.HorizontalLine();
            writer.Log("Press any key to close.");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Writer writer = new Writer();

            writer.Log(appTitle);
            writer.HorizontalLine();
            writer.BlankLine();

            double num1 = readInput(1);
            writer.BlankLine();

            double num2 = readInput(2);
            writer.BlankLine();

            writer.HorizontalLine();
            writer.BlankLine();

            writer.Log("Whats operation would you like to issue");
            writer.Log("\ta - Add");
            writer.Log("\ts - Subtract");
            writer.Log("\tm - Multiply");
            writer.Log("\td - Divide");
            writer.HorizontalLine();

            opertaion(num1, num2, Console.ReadLine());
        }
    }
}
    