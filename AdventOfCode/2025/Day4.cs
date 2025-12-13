using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AoC25
{
    public class Day4
    {
        List<char[]> list = Helper.GetCharListFromFileDay4(
            @"C:\Users\skyy6\Desktop\AoC25files\aoc254.txt"
        );

        public int AoC4part1()
        {
            char[] rowToInsert = new char[list[0].Length];
            Array.Fill(rowToInsert, '.');
            int numOfRolls = 0;

            list.Insert(0, rowToInsert);
            list.Add(rowToInsert);

            for (int i = 1; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    if (list[i][j] == '.')
                    {
                        continue;
                    }
                    if (CanAccessRoll(i, j))
                    {
                        numOfRolls++;
                    }
                }
            }

            return numOfRolls;
        }

        public int AoC4part2()
        {
            char[] rowToInsert = new char[list[0].Length];
            Array.Fill(rowToInsert, '.');
            int numOfRolls = 0;
            bool foundRolls;

            list.Insert(0, rowToInsert);
            list.Add(rowToInsert);

            do
            {
                foundRolls = false;
                for (int i = 1; i < list.Count - 1; i++)
                {
                    for (int j = 0; j < list[i].Length; j++)
                    {
                        if (list[i][j] == '.')
                        {
                            continue;
                        }
                        if (CanAccessRoll(i, j))
                        {
                            numOfRolls++;
                            list[i][j] = '.';
                            foundRolls = true;
                        }
                    }
                }
            } while (foundRolls);

            return numOfRolls;
        }

        private bool CanAccessRoll(int listIndex, int stringIndex)
        {
            char[] adjChars =
            [
                list[listIndex][stringIndex - 1],
                list[listIndex][stringIndex + 1],
                list[listIndex + 1][stringIndex + 1],
                list[listIndex + 1][stringIndex - 1],
                list[listIndex + 1][stringIndex],
                list[listIndex - 1][stringIndex + 1],
                list[listIndex - 1][stringIndex - 1],
                list[listIndex - 1][stringIndex],
            ];
            int ocurr = adjChars.Count(x => x == '@');

            return ocurr < 4;
        }
    }
}
