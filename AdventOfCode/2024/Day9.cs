    public static ulong AoC9part2()
    {
        ulong val = 0;
        int counter = 0;
        var list = new List<string>();
        string value;
        string input;
        bool writeSpace = true;
        string pathSource = @"C:\Users\skyy6\Desktop\input.txt";
        using (FileStream fs = new FileStream(pathSource, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader sr = new StreamReader(fs))
            {
                while ((value = sr.ReadLine()) != null)
                {
                    for (int j = 0; j < value.Length; j++)
                    {
                        writeSpace = !writeSpace;
                        int num = int.Parse(value[j].ToString());
                        string valToAdd = writeSpace ? "." : counter.ToString();
                        for (int i = 0; i < num; i++)
                        {
                            list.Add(valToAdd);
                        }
                        counter = writeSpace ? counter : counter + 1;
                    }
                }
            }
        }
        int rpointer = list.Count - 1;
        var valList = new List<string>();
        while (rpointer > 0)
        {
            if ((valList.Contains(list[rpointer]) || valList.Count == 0) && list[rpointer] != ".")
            {
                valList.Add(list[rpointer]);
                rpointer--;
            }
            else if (list[rpointer] == "." && valList.Count == 0)
            {
                rpointer--;
            }
            else
            {
                int lpointer = 0;
                int dotCounter = 0;
                while (lpointer <= rpointer + 1)
                {
                    if (valList.Count == 0)
                    {
                        break;
                    }
                    if (list[lpointer] == ".")
                    {
                        dotCounter++;
                        lpointer++;
                    }
                    else if (list[lpointer] != "." && dotCounter == 0)
                    {
                        lpointer++;
                    }
                    else
                    {
                        if (valList.Count <= dotCounter && valList.Count != 0)
                        {
                            for (int i = 0; i < valList.Count; i++)
                            {
                                list[lpointer - dotCounter] = valList[i];
                                list[rpointer + i + 1] = ".";
                                dotCounter--;
                            }
                            dotCounter = 0;
                            valList.Clear();
                        }
                        else
                        {
                            dotCounter = 0;
                        }
                    }
                }
                valList.Clear();
            }
        }

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == ".")
            {
                continue;
            }
            else
            {
                val += ulong.Parse(list[i]) * (ulong)i;
            }
        }

        return val;
    }

    /********************************************************************************************************/

    public static ulong AoC9()
    {
        ulong val = 0;
        int counter = 0;
        var list = new List<string>();
        string value;
        string input;
        bool writeSpace = true;
        string pathSource = @"C:\Users\skyy6\Desktop\input.txt";
        using (FileStream fs = new FileStream(pathSource, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader sr = new StreamReader(fs))
            {
                while ((value = sr.ReadLine()) != null)
                {
                    for (int j = 0; j < value.Length; j++)
                    {
                        writeSpace = !writeSpace;
                        int num = int.Parse(value[j].ToString());
                        string valToAdd = writeSpace ? "." : counter.ToString();
                        for (int i = 0; i < num; i++)
                        {
                            list.Add(valToAdd);
                        }
                        counter = writeSpace ? counter : counter + 1;
                    }
                }
            }
        }
        int lpointer = 0;
        int rpointer = list.Count - 1;
        while (lpointer < rpointer)
        {
            if (list[lpointer] == "." && list[rpointer] != ".")
            {
                list[lpointer] = list[rpointer];
                list[rpointer] = ".";
                lpointer++;
                rpointer--;
            }
            else if (list[lpointer] != ".")
            {
                lpointer++;
            }
            else if (list[rpointer] == ".")
            {
                rpointer--;
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == ".")
            {
                continue;
            }
            else
            {
                val += ulong.Parse(list[i]) * (ulong)i;
            }
        }

        return val;
    }