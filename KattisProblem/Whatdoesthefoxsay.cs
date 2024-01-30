using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());


        for(int i = 0; i < testCases; i++){
            string foxSound = Console.ReadLine();
            string input;
            List<string> foxSoundList = new List<string>(foxSound.Split(" "));
            List<string> list = new List<string>();
            while((input = Console.ReadLine()) != "what does the fox say?"){
                list.Add(input.Split(" ").Last());
                             
            }
            foreach(string sound in foxSoundList){
                if(!list.Contains(sound)){
                    Console.WriteLine(sound);
                }
            }

        }

    }
}