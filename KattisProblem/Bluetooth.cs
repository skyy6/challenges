using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();
        List<string> leftSideList = new List<string>();
        List<string> rightSideList = new List<string>();

        bool blueOnLeftSide = false;
        bool blueOnRightSide = false;

        int value;

        string line;

        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            list.Add(line);
        }
        foreach (string str in list)
        {
            bool blueFound = false;
            if (str.Contains('b'))
            {
                blueFound = true;
            }

            if (str[0].Equals('-') || str[0].Equals('+'))
            {
                if (blueFound)
                {
                    blueOnLeftSide = true;
                }
                leftSideList.Add(str);
            }
            else
            {
                if (blueFound)
                {
                    blueOnRightSide = true;
                }
                rightSideList.Add(str);
            }

        }
		
		value = (!blueOnLeftSide && !isTeethMissing(leftSideList)) ? 0 :
		(!blueOnRightSide && !isTeethMissing(rightSideList)) ? 1 : 2;
				
        Console.WriteLine(value);
    }
    static bool isTeethMissing(List<string> teethlist)
    {
        int lowerJawValue = teethlist.Where(x => x != null && x.Contains('-')).Count();
        int upperJawValue = teethlist.Where(x => x != null && x.Contains('+')).Count();
           
        return upperJawValue == 8 || lowerJawValue == 8;   
    }
}