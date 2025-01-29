    public static long AoC11part2()
    {
        long val = 0;
        int blinkCount = 75;
        var list = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }
            list = input.Split(" ").ToList();
        }
        Dictionary<long, long> dict = new Dictionary<long, long>(
            list.ToDictionary(x => long.Parse(x), x => (long)1)
        );
        val = CalcPart2(dict, blinkCount);
        return val;
    }

    private static long CalcPart2(Dictionary<long, long> dict, int blinkCount)
    {
        long stones = 0;
        var cache = new Dictionary<long, List<long>>();
        for (int i = 0; i < blinkCount; i++)
        {
            Dictionary<long, long> blink = new Dictionary<long, long>();
            foreach (var stone in dict.Keys)
            {
                var multiplier = dict[stone];
                foreach (var newStone in updateStone(stone, cache))
                    if (!blink.TryAdd(newStone, multiplier))
                    {
                        blink[newStone] += multiplier;
                    }
            }
            dict = blink;
        }
        foreach (long stone in dict.Keys)
        {
            stones += dict[stone];
        }
        return stones;
    }

    private static List<long> updateStone(long stone, Dictionary<long, List<long>> cache)
    {
        if (cache.ContainsKey(stone))
        {
            return cache[stone];
        }
        string s = stone.ToString();
        var updateStones = new List<long>();
        if (stone == 0)
        {
            updateStones.Add(1);
        }
        else if (s.Length % 2 == 0)
        {
            int middle = s.Length / 2;
            string firstHalf = s.Substring(0, middle);
            string secondHalf = s.Substring(middle, middle).TrimStart('0');
            if (String.IsNullOrEmpty(secondHalf))
            {
                secondHalf = "0";
            }
            updateStones.Add(long.Parse(firstHalf));
            updateStones.Add(long.Parse(secondHalf));
        }
        else
        {
            long val = long.Parse(s) * 2024;
            updateStones.Add(val);
        }
        cache.Add(stone, updateStones);
        return updateStones;
    }

    /********************************************************************************************************/
    public static int AoC11()
    {
        ulong val = 0;
        int stones = 0;
        int blinkCount = 45;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }
            var list = new List<string>(input.Split(" "));
            stones = Calc(list, blinkCount, 8);
        }
        return stones;
    }

    private static int Calc(List<string> list, int blinkCount, ulong stoneCount)
    {
        var revList = new List<string>();
        if (blinkCount == 0)
        {
            return list.Count();
        }
        for (int i = 0; i < list.Count(); i++)
        {
            if (list[i] == "0")
            {
                revList.Add("1");
                continue;
            }
            if (list[i].Length % 2 == 0)
            {
                int middle = list[i].Length / 2;
                string firstHalf = list[i].Substring(0, middle);
                string secondHalf = list[i].Substring(middle, middle).TrimStart('0');
                if (String.IsNullOrEmpty(secondHalf))
                {
                    secondHalf = "0";
                }
                revList.Add(firstHalf);
                revList.Add(secondHalf);
            }
            else
            {
                ulong val = ulong.Parse(list[i]) * 2024;
                revList.Add(val.ToString());
            }
        }
        blinkCount--;
        return Calc(revList, blinkCount, 0);
    }