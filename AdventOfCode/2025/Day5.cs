using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace AoC25
{
    public class Day5
    {
        List<long> compareList = new();
        List<long> vals = new();
        Dictionary<long, long> rangeDict = new();
        Dictionary<long, long> ansDict = new();

        public int AoC5part1()
        {
            int sum = 0;
            PopulateLongLists();
            for (int i = 0; i < vals.Count; i++)
            {
                for (int j = 0; j < compareList.Count - 1; j += 2)
                {
                    if (vals[i] >= compareList[j] && vals[i] <= compareList[j + 1])
                    {
                        sum++;
                        break;
                    }
                }
            }
            return sum;
        }

        public long AoC5part2()
        {
            PopulateRangeDictionary();

            long sum = 0;

            rangeDict = rangeDict.OrderBy(x => x.Key).ToDictionary();
            ansDict.Add(rangeDict.Keys.ElementAt(0), rangeDict.Values.ElementAt(0));

            for (int i = 1; i < rangeDict.Keys.Count; i++)
            {
                long currentKey = rangeDict.Keys.ElementAt(i);
                long prevValue = ansDict.Values.ElementAt(ansDict.Keys.Count - 1);
                long prevKey = ansDict.Keys.ElementAt(ansDict.Keys.Count - 1);
                if (currentKey - 1 <= prevValue)
                {
                    if (rangeDict[currentKey] <= prevValue)
                    {
                        continue;
                    }
                    ansDict[prevKey] = rangeDict[currentKey];
                    continue;
                }
                else
                {
                    ansDict.Add(currentKey, rangeDict[currentKey]);
                }
            }
            foreach (long key in ansDict.Keys)
            {
                sum += ansDict[key] - key + 1;
            }

            return sum;
        }

        public void PopulateLongLists()
        {
            string input;

            string pathSource = @"C:\Users\skyy6\Desktop\AoC25files\aoc255.txt";
            using (FileStream fs = new FileStream(pathSource, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while ((input = sr.ReadLine()) != null)
                    {
                        if (input == "")
                        {
                            continue;
                        }
                        if (input.Contains('-'))
                        {
                            compareList.Add(long.Parse(input.Split('-')[0]));
                            compareList.Add(long.Parse(input.Split('-')[1]));
                        }
                        else
                        {
                            vals.Add(long.Parse(input));
                        }
                    }
                }
            }
        }

        public void PopulateRangeDictionary()
        {
            string input;

            string pathSource = @"C:\Users\skyy6\Desktop\AoC25files\aoc255.txt";
            using (FileStream fs = new FileStream(pathSource, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while ((input = sr.ReadLine()) != null)
                    {
                        if (input == "")
                        {
                            break;
                        }
                        if (input.Contains('-'))
                        {
                            long key = long.Parse(input.Split('-')[0]);
                            long val = long.Parse(input.Split('-')[1]);
                            if (rangeDict.ContainsKey(key))
                            {
                                if (rangeDict[key] < val)
                                {
                                    rangeDict[key] = val;
                                    continue;
                                }
                            }
                            else
                            {
                                rangeDict.Add(key, val);
                            }
                        }
                    }
                }
            }
        }
    }
}
