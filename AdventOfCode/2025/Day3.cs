using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC25
{
    public class Day3
    {
        public long AoC3part1()
        {
            List<string> list = Helper.GetListFromFile(
                @"C:\Users\skyy6\Desktop\AoC25files\aoc253.txt"
            );

            List<long> valueList = new();

            foreach (string s in list)
            {
                int[] battery = s.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
                int lPointer = 0;
                int rPointer = 1;
                int secondVal = battery[rPointer];
                string value;
                while (rPointer < battery.Length)
                {
                    if (battery[rPointer] > battery[lPointer] && rPointer != battery.Length - 1)
                    {
                        lPointer = rPointer;
                        rPointer = lPointer + 1;
                        secondVal = battery[rPointer];
                        continue;
                    }
                    if (battery[rPointer] > secondVal)
                    {
                        secondVal = battery[rPointer];
                    }
                    rPointer++;
                }
                value = battery[lPointer].ToString() + secondVal.ToString();
                valueList.Add(long.Parse(value));
            }
            return valueList.Sum();
        }

        public long AoC3part2()
        {
            List<string> list = Helper.GetListFromFile(
                @"C:\Users\skyy6\Desktop\AoC25files\aoc253.txt"
            );
            long sum = 0;

            foreach (string s in list)
            {
                int[] battery = s.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
                List<int> valueList = new();
                for (int i = 0; i < battery.Length; i++)
                {
                    if (valueList.Count == 0)
                    {
                        valueList.Add(battery[i]);
                        continue;
                    }
                    bool shouldAppend = valueList.Count < 12;
                    for (int j = 0; j < valueList.Count; j++)
                    {
                        if (battery[i] > valueList[j] && battery.Length - i >= 12 - j)
                        {
                            valueList[j] = battery[i];
                            valueList.RemoveRange(j + 1, valueList.Count - (j + 1)); //asdåligt, borde gjort stringbuilder istället för detta
                            shouldAppend = false;
                            break;
                        }
                    }
                    if (shouldAppend)
                    {
                        valueList.Add(battery[i]);
                    }
                }
                string result = string.Join("", valueList);
                sum += long.Parse(result);
            }

            return sum;
        }
    }
}
