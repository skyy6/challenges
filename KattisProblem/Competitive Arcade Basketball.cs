using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

internal class Program
{     static void Main(string[] args)
    {
        string input = Console.ReadLine();

        bool foundWinner = false;
        
        int n = int.Parse(input.Split(" ")[0]);
        int p = int.Parse(input.Split(" ")[1]);
        int m = int.Parse(input.Split(" ")[2]);
        
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        for(int i = 0; i < n; i++){
            string name = Console.ReadLine();
            dict.Add(name, 0);
        }

        for(int y = 0; y < m; y++){
            string nameAndPoints = Console.ReadLine();
            string name = nameAndPoints.Split(" ")[0];
            int points =  int.Parse(nameAndPoints.Split(" ")[1]);
            dict[name] += points;

        }
        var winners = dict.Where(x => x.Value >= p);
        foreach(var person in winners){
                Console.WriteLine(person.Key + " wins!");
                foundWinner = true;
        }

        if(!foundWinner){
            Console.WriteLine("No winner!");
        }
    }
}