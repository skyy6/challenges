    public static int AoC6part2()
    { 
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        List<List<char>> chars = new List<List<char>>();
        var indexList = new List<string>();
        bool isGuarding = true;
        int firstIndex = 0;
        int secondIndex = 0;
        int val = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }
            List<char> list = new List<char>();
            list.AddRange(input.Select(i => i));
            chars.Add(list);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '^' || input[i] == '>' || input[i] == '<' || input[i] == 'v')
                {
                    firstIndex = chars.Count - 1;
                    secondIndex = i;
                }
            }
        }
        for (int i = 0; i < chars.Count; i++)
        {
            for (int j = 0; j < chars[i].Count; j++)
            {
                List<List<char>> charsCopy = new List<List<char>>();
                foreach (var sublist in chars)
                {
                    charsCopy.Add(new List<char>(sublist));
                }
                if (charsCopy[i][j] != '#')
                {
                    if (i == firstIndex && j == secondIndex)
                    {
                        continue;
                    }
                    charsCopy[i][j] = '#';
                    int startPosRow = firstIndex;
                    int startPosCol = secondIndex;
                    indexList.Clear();
                    val += GuardCheck(startPosRow, startPosCol, charsCopy, indexList);
                }
                else
                {
                    continue;
                }
            }
        }
        return val;
    }

    private static int GuardCheck(
        int firstIndex,
        int secondIndex,
        List<List<char>> chars,
        List<string> indexList
    )
    {
        int val = 0;
        bool isGuarding = true;
        while (isGuarding)
        {
            if (chars[firstIndex][secondIndex] == '^')
            {
                bool obstructed = false;
                try
                {
                    while (!obstructed)
                    {
                        if (chars[firstIndex - 1][secondIndex] != '#')
                        {
                            firstIndex--;
                        }
                        else
                        {
                            string index =
                                "^" + firstIndex.ToString() + "," + secondIndex.ToString();
                            if (!indexList.Contains(index))
                            {
                                indexList.Add(index);
                            }
                            else
                            {
                                val++;
                                return val;
                            }
                            obstructed = true;
                            chars[firstIndex][secondIndex] = '>'; //Ful lösning men det gör inget att ursprungspositionen fortfarande är en pil
                        }
                    }
                }
                catch
                {
                    isGuarding = false;
                }
            }
            if (chars[firstIndex][secondIndex] == '<')
            {
                bool obstructed = false;
                try
                {
                    while (!obstructed)
                    {
                        if (chars[firstIndex][secondIndex - 1] != '#')
                        {
                            secondIndex--;
                        }
                        else
                        {
                            string index =
                                "<" + firstIndex.ToString() + "," + secondIndex.ToString();
                            if (!indexList.Contains(index))
                            {
                                indexList.Add(index);
                            }
                            else
                            {
                                val++;
                                return val;
                            }
                            obstructed = true;
                            chars[firstIndex][secondIndex] = '^'; //Ful lösning men det gör inget att ursprungspositionen fortfarande är en pil
                        }
                    }
                }
                catch
                {
                    isGuarding = false;
                }
            }
            if (chars[firstIndex][secondIndex] == '>')
            {
                bool obstructed = false;
                try
                {
                    while (!obstructed)
                    {
                        if (chars[firstIndex][secondIndex + 1] != '#')
                        {
                            secondIndex++;
                        }
                        else
                        {
                            string index =
                                ">" + firstIndex.ToString() + "," + secondIndex.ToString();
                            if (!indexList.Contains(index))
                            {
                                indexList.Add(index);
                            }
                            else
                            {
                                val++;
                                return val;
                            }
                            obstructed = true;
                            chars[firstIndex][secondIndex] = 'v'; //Ful lösning men det gör inget att ursprungspositionen fortfarande är en pil
                        }
                    }
                }
                catch
                {
                    isGuarding = false;
                }
            }
            if (chars[firstIndex][secondIndex] == 'v')
            {
                bool obstructed = false;
                try
                {
                    while (!obstructed)
                    {
                        if (chars[firstIndex + 1][secondIndex] != '#')
                        {
                            firstIndex++;
                        }
                        else
                        {
                            string index =
                                "v" + firstIndex.ToString() + "," + secondIndex.ToString();
                            if (!indexList.Contains(index))
                            {
                                indexList.Add(index);
                            }
                            else
                            {
                                val++;
                                return val;
                            }
                            obstructed = true;
                            chars[firstIndex][secondIndex] = '<';
                        }
                    }
                }
                catch
                {
                    isGuarding = false;
                }
            }
        }
        return 0;
    }

    /********************************************************************************************************/
    public static int AoC6()
    { 
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        List<List<char>> chars = new List<List<char>>();
        var indexList = new List<string>();
        bool isGuarding = true;
        int firstIndex = 0;
        int secondIndex = 0;
        int val = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }
            List<char> list = new List<char>();
            list.AddRange(input.Select(i => (char)i));
            chars.Add(list);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '^' || input[i] == '>' || input[i] == '<' || input[i] == 'v')
                {
                    firstIndex = chars.Count - 1;
                    secondIndex = i;
                }
            }
        }
        while (isGuarding)
        {
            if (chars[firstIndex][secondIndex] == '^')
            {
                bool obstructed = false;
                try
                {
                    while (!obstructed)
                    {
                        string index = firstIndex.ToString() + "," + secondIndex.ToString();
                        if (!indexList.Contains(index))
                        {
                            indexList.Add(index);
                        }
                        if (chars[firstIndex - 1][secondIndex] != '#')
                        {
                            firstIndex--;
                        }
                        else
                        {
                            obstructed = true;
                            chars[firstIndex][secondIndex] = '>'; //Ful lösning men det gör inget att ursprungspositionen fortfarande är en pil
                        }
                    }
                }
                catch
                {
                    val++;
                    isGuarding = false;
                }
            }
            if (chars[firstIndex][secondIndex] == '<')
            {
                bool obstructed = false;
                try
                {
                    while (!obstructed)
                    {
                        string index = firstIndex.ToString() + "," + secondIndex.ToString();
                        if (!indexList.Contains(index))
                        {
                            indexList.Add(index);
                        }
                        if (chars[firstIndex][secondIndex - 1] != '#')
                        {
                            secondIndex--;
                        }
                        else
                        {
                            obstructed = true;
                            chars[firstIndex][secondIndex] = '^'; //Ful lösning men det gör inget att ursprungspositionen fortfarande är en pil
                        }
                    }
                }
                catch
                {
                    val++;
                    isGuarding = false;
                }
            }
            if (chars[firstIndex][secondIndex] == '>')
            {
                bool obstructed = false;
                try
                {
                    while (!obstructed)
                    {
                        string index = firstIndex.ToString() + "," + secondIndex.ToString();
                        if (!indexList.Contains(index))
                        {
                            indexList.Add(index);
                        }
                        if (chars[firstIndex][secondIndex + 1] != '#')
                        {
                            secondIndex++;
                        }
                        else
                        {
                            obstructed = true;
                            chars[firstIndex][secondIndex] = 'v'; //Ful lösning men det gör inget att ursprungspositionen fortfarande är en pil
                        }
                    }
                }
                catch
                {
                    val++;
                    isGuarding = false;
                }
            }
            if (chars[firstIndex][secondIndex] == 'v')
            {
                bool obstructed = false;
                try
                {
                    while (!obstructed)
                    {
                        string index = firstIndex.ToString() + "," + secondIndex.ToString();
                        if (!indexList.Contains(index))
                        {
                            indexList.Add(index);
                        }
                        if (chars[firstIndex + 1][secondIndex] != '#')
                        {
                            firstIndex++;
                        }
                        else
                        {
                            obstructed = true;
                            chars[firstIndex][secondIndex] = '<';
                        }
                    }
                }
                catch
                {
                    val++;
                    isGuarding = false;
                }
            }
        }
        return indexList.Count;
    }