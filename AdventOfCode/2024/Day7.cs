    public static ulong AoC7part2()
    {
        ulong val = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }
            ulong correctVal = ulong.Parse(input.Split(':')[0]);
            string[] arr = input.Split(":")[1].Trim().Split(" ");
            var list = new List<ulong>();
            list.AddRange(arr.Select(x => ulong.Parse(x)));
            bool canSolve = SolvePartTwo(correctVal, list, list[0], 0);
            if (canSolve)
            {
                val += correctVal;
            }
            else
            {
                continue;
            }
        }
        return val;
    }

    private static bool SolvePartTwo(
        ulong correctVal,
        List<ulong> list,
        ulong currentVal,
        int currentIndex
    )
    {
        if (currentVal > correctVal)
        {
            return false;
        }
        if (currentIndex == list.Count - 1)
        {
            return currentVal == correctVal;
        }

        if (SolvePartTwo(correctVal, list, currentVal + list[currentIndex + 1], currentIndex + 1))
        {
            return true;
        }
        if (SolvePartTwo(correctVal, list, currentVal * list[currentIndex + 1], currentIndex + 1))
        {
            return true;
        }
        if (
            SolvePartTwo(
                correctVal,
                list,
                ulong.Parse(currentVal.ToString() + list[currentIndex + 1].ToString()),
                currentIndex + 1
            )
        )
        {
            return true;
        }
        return false;
    }

    /********************************************************************************************************/

    public static ulong AoC7()
    {
        ulong val = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }
            ulong correctVal = ulong.Parse(input.Split(':')[0]);
            string[] arr = input.Split(":")[1].Trim().Split(" ");
            var list = new List<ulong>();
            list.AddRange(arr.Select(x => ulong.Parse(x)));
            bool canSolve = Solve(correctVal, list, list[0], 0);
            if (canSolve)
            {
                val += correctVal;
            }
            else
            {
                continue;
            }
        }
        return val;
    }

    private static bool Solve(
        ulong correctVal,
        List<ulong> list,
        ulong currentVal,
        int currentIndex
    )
    {
        if (currentVal > correctVal)
        {
            return false;
        }
        if (currentIndex == list.Count - 1)
        {
            return currentVal == correctVal;
        }

        if (Solve(correctVal, list, currentVal + list[currentIndex + 1], currentIndex + 1))
        {
            return true;
        }
        if (Solve(correctVal, list, currentVal * list[currentIndex + 1], currentIndex + 1))
        {
            return true;
        }
        return false;
    }