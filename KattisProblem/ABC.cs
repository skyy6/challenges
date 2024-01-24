using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();
        Dictionary<char, int> nums = new Dictionary<char, int>();   

        string numberString = Console.ReadLine();
        string ABC = Console.ReadLine();

        int[] numbers = numberString.Split(" ").Select(int.Parse).ToArray();
        Array.Sort(numbers);
            nums.Add(key:'A', value: numbers[0]);
            nums.Add(key:'B', value: numbers[1]);
            nums.Add(key:'C', value: numbers[2]);
        
        Console.WriteLine(nums[ABC[0]]+ " " + nums[ABC[1]] + " " + nums[ABC[2]]);
    }
}   