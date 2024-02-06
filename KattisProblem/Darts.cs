using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

internal class Program
{     static void Main(string[] args)
    {
        int testcases = int.Parse(Console.ReadLine());
        Dictionary<int, int> dict = new Dictionary<int, int>()
        {
            {20, 10},
            {40, 9},
            {60, 8},
            {80, 7},
            {100, 6},
            {120, 5},
            {140, 4},
            {160, 3},
            {180, 2},
            {200, 1}
        };

        for(int i = 0; i < testcases; i++){
            int sum = 0;
            int throws = int.Parse(Console.ReadLine());
            for(int x = 0; x < throws; x++){
                string[] inputs = Console.ReadLine().Split(" ");
                int firstThrow = Math.Abs(int.Parse(inputs[0]));
                int secondThrow = Math.Abs(int.Parse(inputs[1]));
                double throwsum = Math.Pow(firstThrow,2) + Math.Pow(secondThrow,2);
                double r = Math.Sqrt(throwsum);
                for(int y = 0; y < dict.Keys.Count; y++){
                    if(r <= dict.Keys.ElementAt(y)){
                        sum += dict.Values.ElementAt(y);
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }


    }
}