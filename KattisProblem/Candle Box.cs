using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int ageDiff = int.Parse(Console.ReadLine());
        int rc = int.Parse(Console.ReadLine());
        int tc = int.Parse(Console.ReadLine());
        int sumOfCandles = tc + rc;
        int tinaCandles = 0;
        int theoCandles = 0;
        int theoCounter = 3;

        for(int r = 4; tinaCandles + theoCandles < sumOfCandles; r++){
            tinaCandles += r;
            if(ageDiff == 1){
                theoCandles += theoCounter;
                theoCounter++;
            }
            else{
                ageDiff--;
            }   
        }
        Console.WriteLine(rc - tinaCandles);
    }
}