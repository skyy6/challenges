using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace AoC25
{
    public class Day2
    {
        public long AoC2part1()
        {
            List<string> inputList = Helper.SplitStringReturnList(',');
            List<long> listOfId = new();
            foreach (string input in inputList)
            {
                long startIntVal = long.Parse(input.Split('-')[0]);
                long endIntVal = long.Parse(input.Split('-')[1]);
                for (long i = startIntVal; i <= endIntVal; i++)
                {
                    bool isValidID = true;
                    string val = i.ToString();
                    int lPointer = 0;
                    int rPointer = val.Length / 2;
                    if (val.Length % 2 != 0)
                    {
                        continue;
                    }
                    while (rPointer < val.Length)
                    {
                        if (val[lPointer] == val[rPointer])
                        {
                            lPointer++;
                            rPointer++;
                            continue;
                        }
                        else
                        {
                            isValidID = false;
                            break;
                        }
                    }
                    if (isValidID)
                    {
                        listOfId.Add(i);
                    }
                }
            }
            return listOfId.Sum();
        }

        public long AoC2part2()
        {
            List<string> inputList = Helper.SplitStringReturnList(',');
            List<long> listOfId = new();
            foreach (string input in inputList)
            {
                long startIntVal = long.Parse(input.Split('-')[0]);
                long endIntVal = long.Parse(input.Split('-')[1]);
                for (long i = startIntVal; i <= endIntVal; i++)
                {
                    string val = i.ToString();
                    if (val.Distinct().Count() == 1 && val.Length > 1)
                    {
                        listOfId.Add(i);
                        continue;
                    }
                    else if (val.Length <= 3)
                    {
                        continue;
                    }
                    bool isInvalidID = false;
                    int lIndex = 0;
                    int rLength = 2;
                    while (lIndex + rLength + rLength <= val.Length)
                    {
                        string subString = val.Substring(lIndex, rLength);
                        string subStringCompare = val.Substring(lIndex + rLength, rLength);
                        if (subString == subStringCompare)
                        {
                            lIndex = lIndex + rLength;
                            if (lIndex + rLength == val.Length)
                            {
                                isInvalidID = true;
                            }
                        }
                        else
                        {
                            lIndex = 0;
                            rLength += 1;
                            isInvalidID = false;
                        }
                    }
                    if (isInvalidID)
                    {
                        listOfId.Add(i);
                    }
                }
            }
            return listOfId.Sum();
        }
    }
}
