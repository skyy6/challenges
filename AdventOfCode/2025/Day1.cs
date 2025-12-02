// See https://aka.ms/new-console-template for more information

using System.Formats.Tar;
using System.Windows.Markup;

static List<string> ListFromFile()
{
    string input;
    List<string> vals = new List<string>();
    string pathSource = @"C:\Users\skyy6\Desktop\aoc251.txt";
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

static void AoC1part1()
{
    int pos = 50;
    long zeroCounter = 0;
    List<string> vals = ListFromFile();

    foreach (string val in vals)
    {
        int number = int.Parse(val.Substring(1, val.Length - 1));
        pos = val[0] == 'L' ? pos -= number : pos += number;
        pos = pos % 100;
        zeroCounter = pos == 0 ? zeroCounter += 1 : zeroCounter += 0;
    }
    Console.WriteLine(zeroCounter);
}

static void AoC1part2()
{
    int pos = 50;
    long zeroCounter = 0;
    double part2Ans = 0;
    List<string> vals = ListFromFile();
    foreach (string val in vals)
    {
        double initialPercentage = 0;
        int number = int.Parse(val.Substring(1, val.Length - 1));
        double addedPercentage = number / 100.0;
        if (val[0] == 'L')
        {
            initialPercentage = (100.0 - pos) / 100.0;

        }
        else
        {
            initialPercentage = pos / 100.0;

        }
		    part2Ans +=
                pos == 0
                    ? Math.Floor((addedPercentage))
                    : Math.Floor((addedPercentage + initialPercentage));<
					
        pos = val[0] == 'L' ? pos -= number : pos += number;
        pos = ((pos % 100) + 100) % 100;
        if(pos == 0){
			zeroCounter++
		}
    }
    Console.WriteLine(part2Ans);
}
