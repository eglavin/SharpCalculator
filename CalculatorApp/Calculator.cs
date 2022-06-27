using System;

class Calculator
{
    public string GetOperationIcon(string operation)
    {
        switch (operation.ToLower())
        {
            case "a":
                return "+";
            case "s":
                return "-";
            case "m":
                return "*";
            case "d":
                return "/";
        }
        return "";
    }
    public bool IsOperationValid(string operation)
    {
        if (GetOperationIcon(operation) != "")
        {
            return true;
        }
        return false;
    }

    string HORIZONTAL_LINE = "=============================";
    public string ReadOperation(string message)
    {
        Console.WriteLine(HORIZONTAL_LINE);
        Console.WriteLine("List of operations:");
        Console.WriteLine("");
        Console.WriteLine("\tKey | Label");
        Console.WriteLine("\t-----------");
        Console.WriteLine("\ta - Add");
        Console.WriteLine("\ts - Subtract");
        Console.WriteLine("\tm - Multiply");
        Console.WriteLine("\td - Divide");
        Console.WriteLine("\tq - Quit Now!");
        Console.WriteLine("");
        Console.WriteLine(HORIZONTAL_LINE);
        Console.WriteLine("");

        string operation;

        try
        {
            Console.Write($"{message}: ");

            operation = Console.ReadKey().KeyChar + "";
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            operation = "_";
        }

        Console.WriteLine("\n");

        return operation;
    }

    public double ReadNumber(string message)
    {
        double returnValue;

        try
        {
            Console.Write($"\n{message}: ");

            returnValue = Convert.ToDouble(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Invalid Number, Please try again!");

            returnValue = Double.PositiveInfinity;
        }

        return returnValue;
    }

    public bool UsePreviousValue()
    {
        Console.Write("Press y to use previous value. ");

        char value = Console.ReadKey().KeyChar;
        if (value == 'y')
        {
            return true;
        }

        return false;
    }

    double Add(double num1, double num2)
    {
        return num1 + num2;
    }
    double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }
    double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }
    double Divide(double num1, double num2)
    {
        return num1 / num2;
    }
    public double Calculate(string operation, double num1, double num2)
    {
        switch (operation.ToLower())
        {
            case "a":
                return Add(num1, num2);
            case "s":
                return Subtract(num1, num2);
            case "m":
                return Multiply(num1, num2);
            case "d":
                return Divide(num1, num2);
        }
        return Double.PositiveInfinity;
    }
}
