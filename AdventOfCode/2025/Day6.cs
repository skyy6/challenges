using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AoC25
{
    public class Day6
    {
        public long AoC6part1()
        {
            List<List<string>> list = Helper.SplitStringReturnListOfList(' ');
            List<List<int>> intList = list.GetRange(0, list.Count - 1)
                .Select(x => x.Select(y => int.Parse(y)).ToList())
                .ToList();
            long sum = 0;
            var max = list.Select(x => x.Max(y => y.Length)).FirstOrDefault();

            for (int i = 0; i < list[0].Count; i++)
            {
                bool shouldMultiply = list[list.Count - 1][i] == "*";
                long valPerList = 0;

                for (int j = 0; j < intList.Count; j++)
                {
                    if (shouldMultiply)
                    {
                        valPerList = valPerList == 0 ? intList[j][i] : intList[j][i] * valPerList;
                    }
                    else
                    {
                        valPerList = intList[j][i] + valPerList;
                    }
                }
                sum += valPerList;
            }
            return sum;
        }

        public long AoC6part2()
        {
            List<string> stringList = Helper.GetListFromFile(
                @"C:\Users\skyy6\Desktop\AoC25files\aoc256.txt"
            );
            long sum = 0;
            List<long> valueList = new();
            bool shouldMultiply = false;

            for (int i = 0; i < stringList[0].Length; i++)
            {
                List<char> t = new();
                StringBuilder sb = new();

                for (int j = 0; j < stringList.Count; j++)
                {
                    char c = stringList[j][i];
                    if (c == '+' || c == '*')
                    {
                        shouldMultiply = c == '*';
                        continue;
                    }
                    t.Add(c);
                    sb.Append(c);
                }
                if (t.Where(x => x != ' ').ToList().Count == 0 || i == stringList[0].Length - 1)
                {
                    if (i == stringList[0].Length - 1)
                    {
                        valueList.Add(int.Parse(sb.ToString().Trim()));
                    }
                    if (shouldMultiply)
                    {
                        sum += valueList.Aggregate((x, y) => x * y);
                    }
                    else
                    {
                        sum += valueList.Sum();
                    }
                    valueList.Clear();
                }
                else
                {
                    valueList.Add(long.Parse(sb.ToString().Trim()));
                }
            }
            return sum;
        }
    }
}
