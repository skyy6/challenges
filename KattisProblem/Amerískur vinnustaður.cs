using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

class Program
{

    static List<string> list = new List<string>();
    static List<string> splitlist = new List<string>();
    static void Main()
    {
        int units = 0;
        string line;
        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            units = Int32.Parse(line);
        }
        double unitsFloat = (double)units;
        double convNum = unitsFloat / 10.9361329834;

        Console.WriteLine(convNum);
      
    }

}