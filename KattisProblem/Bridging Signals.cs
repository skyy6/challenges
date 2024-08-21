using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

internal class Program
{  
        static int LengthOfLIS(List<int> nums)
    {
        int n = nums.Count;
        List<int> ans = new List<int>();

        ans.Add(nums[0]);

        for (int i = 1; i < n; i++)
        {
            if (nums[i] > ans[ans.Count - 1])
            {
                ans.Add(nums[i]);
            }
            else
            {

                int low = ans.BinarySearch(nums[i]);

                if (low < 0)
                {
                    low = ~low;
                }
                ans[low] = nums[i];
            }
        }

        return ans.Count;
    }
   
    static void Main(string[] args)
    {
        int numOfRows = int.Parse(Console.ReadLine());
        List<int> nums = new List<int>();
        
        for (int i = 0; i < numOfRows; i++){
            int num = int.Parse(Console.ReadLine());
            nums.Add(num);
        }
        
        Console.WriteLine(LengthOfLIS(nums));
    }
}