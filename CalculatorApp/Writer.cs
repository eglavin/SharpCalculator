using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Writer
{
    public void Log(string name)
    {
        Console.WriteLine($"{name}");
    }
    public void HorizontalLine()
    {
        Console.WriteLine("=============================");
    }
    public void BlankLine()
    {
        Console.WriteLine("");
    }
}
