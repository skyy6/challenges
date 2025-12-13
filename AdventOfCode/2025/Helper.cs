using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AoC25
{
    public class Helper
    {
        public static List<string> GetListFromFile(string path)
        {
            string input;
            List<string> vals = new List<string>();
            string pathSource = @$"{path}";
            using (FileStream fs = new FileStream(pathSource, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while ((input = sr.ReadLine()) != null)
                    {
                        vals.Add(input);
                    }
                }
            }
            return vals;
        }

        public static List<char[]> GetCharListFromFileDay4(string path)
        {
            string input;
            List<char[]> chars = new List<char[]>();
            string pathSource = @$"{path}";
            using (FileStream fs = new FileStream(pathSource, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while ((input = sr.ReadLine()) != null)
                    {
                        input = $".{input}.";
                        chars.Add(input.ToCharArray());
                    }
                }
            }
            return chars;
        }

        public static List<string> GetInputFromConsoleRead()
        {
            List<string> list = new();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                list.Add(input);
            }
            return list;
        }

        public static List<string> SplitStringReturnList(char c)
        {
            string input;
            List<string> vals = new List<string>();
            string pathSource = @"C:\Users\skyy6\Desktop\aoc252.txt";
            using (FileStream fs = new FileStream(pathSource, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while ((input = sr.ReadLine()) != null)
                    {
                        vals = input.Split(c).ToList();
                    }
                }
            }
            return vals;
        }
    }
}
