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
        StringBuilder sb = new StringBuilder();
        string line;
        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            list.Add(line);
        }
        
        if(list[1].Contains(" ")){
            splitlist = list[1].Split(" ").ToList();
            foreach(var item in splitlist){
                char test = item[0];
                if(char.IsUpper(test)){
                    sb.Append(test);
                }
            }
        }
        else{
            sb.Append(list[1][0]);
        }

        Console.WriteLine(sb);

    }

}