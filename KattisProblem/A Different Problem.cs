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
        string line;
        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            list.Add(line);
        }
        foreach(string str in list){
            splitlist = str.Split(" ").ToList();
            long firstVal = Int64.Parse(splitlist[0]);
            long secondVal = Int64.Parse(splitlist[1]);
            long diff = Math.Max(firstVal, secondVal) - Math.Min(firstVal,secondVal);
            Console.WriteLine(diff);
        }

      
    }

}