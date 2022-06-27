using System;

namespace CalculatorApp
{
    class Program
    {
        static string APP_TITLE = "Console Calculator in C#";
        static string OPERATION_MESSAGE = "What operation would you like to calculate?";
        static string ENTER_NUMBER_MESSAGE(int count) => $"Type number {count}, and press Enter";
        static string RESULT_MESSAGE = "Result:";
        static string ERROR_MESSAGE = "Error calculating result.";
        static string END_MESSAGE = "Press escape or q to exit, or any other button to continue.";

        static void Main(string[] args)
        {
            double lastResult = Double.PositiveInfinity;

            while (true) {
                Calculator calculator = new Calculator();
                Console.WriteLine(APP_TITLE);

                string operation;
                double num1, num2;

                do {
                    operation = calculator.ReadOperation(OPERATION_MESSAGE);

                    if (operation.ToLower() == "q") {
                        return;
                    }
                } while (calculator.IsOperationValid(operation) == false);

                do {
                    if (lastResult != Double.PositiveInfinity && calculator.UsePreviousValue())
                    {
                        num1 = lastResult;
                    }
                    else
                    {
                        num1 = calculator.ReadNumber(ENTER_NUMBER_MESSAGE(1));
                    }
                } while (num1 == Double.PositiveInfinity);

                do {
                    num2 = calculator.ReadNumber(ENTER_NUMBER_MESSAGE(2));
                } while (num2 == Double.PositiveInfinity);

                string operationIcon = calculator.GetOperationIcon(operation);
                double result = calculator.Calculate(operation, num1, num2);

                if (result != Double.PositiveInfinity)
                {
                    lastResult = result;
                    Console.WriteLine($"\n{RESULT_MESSAGE} {num1} {operationIcon} {num2} = {result}.");
                }
                else
                {
                    Console.WriteLine($"\n{ERROR_MESSAGE}");
                }


                Console.Write($"\n{END_MESSAGE}");
                string exit = Console.ReadKey().Key.ToString().ToLower();

                if (exit == "escape" || exit == "q") {
                    return;
                }

                Console.Write("\n");
            }
        }
    }
}
    