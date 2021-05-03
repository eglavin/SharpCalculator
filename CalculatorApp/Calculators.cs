using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Calculators
{
    public static Func<double, double, double> adition = (num1, num2) => num1 + num2;
    public static Func<double, double, double> subtraction = (num1, num2) => num1 - num2;
    public static Func<double, double, double> multiply = (num1, num2) => num1 * num2;
    public static Func<double, double, double> divide = (num1, num2) => num1 / num2;

}

