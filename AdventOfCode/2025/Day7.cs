using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace AoC25
{
    public class Day7
    {
        List<string> list = Helper.GetListFromFile(@"C:\Users\skyy6\Desktop\AoC25files\aoc257.txt");
        HashSet<(int, int)> set = new();

        public int AoC7part1()
        {
            list = list.Where(s => s.Any(c => c != '.')).ToList();
            char[][] charArray = list.Select(x => x.ToCharArray()).ToArray();
            int startIndex = list[0].IndexOf('S');
            set.Add((1, startIndex));
            LoopGrid(charArray);
            return set.Count;
        }

        public void LoopGrid(char[][] charArray)
        {
            for (int i = 2; i < charArray.Length; i++)
            {
                for (int j = 0; j < charArray[0].Length; j++)
                {
                    try
                    {
                        if (charArray[i][j] == '^')
                        {
                            if (
                                charArray[i - 1][j - 1] == '^'
                                || charArray[i - 1][j + 1] == '^'
                                || charArray[i - 1][j] == '-'
                            )
                            {
                                set.Add((i, j));
                            }
                        }
                        else if (
                            (charArray[i][j] == '.')
                                && (
                                    charArray[i - 1][j - 1] == '^' || charArray[i - 1][j + 1] == '^'
                                )
                            || charArray[i - 1][j] == '-'
                        )
                        {
                            charArray[i][j] = '-';
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }
    }
}
