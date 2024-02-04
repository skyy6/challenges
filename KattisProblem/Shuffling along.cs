using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

internal class Program
{     static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int counter = 0;
        int lastInd = 0;
        List<int> list = new List<int>();
        List<int> checklist = new List<int>();
        List<int> secondList, firstList;
        List<int> smallerList, biggerList;
        int deck = int.Parse(input.Split(" ")[0]);

        bool isEven = deck % 2 == 0;
        bool isOut = false;

        if(input.Split(" ")[1] == "out"){
            isOut = true;
        }

        for(int i = 1; i <= deck; i++){
            list.Add(i);
        }
        (firstList, secondList) = shuffler(isEven, isOut,list);
        biggerList = (firstList.Count > secondList.Count) ? firstList : secondList;

        while(!checklist.SequenceEqual(list)){
            checklist.Clear();
            counter++;
                   
        for(int i = 0; i < biggerList.Count; i++){

                if(i > firstList.Count - 1){
                    checklist.Add(secondList[i]);
                }
                else if (i > secondList.Count - 1){
                    checklist.Add(firstList[i]);
                }
                else{
            checklist.Add(isOut ?  firstList[i] : secondList[i]);
            checklist.Add(isOut ? secondList[i] : firstList[i]); }
        }

        (firstList, secondList) = shuffler(isEven, isOut, checklist);        
    }
    Console.WriteLine(counter);
    }

     public static (List<int>, List<int>) shuffler(bool isEven, bool isOut, List<int> list){
        
        int halfCount = isEven ? list.Count / 2 : (isOut ? list.Count / 2 + 1 : list.Count / 2);
        List<int> firstList = list.Take(halfCount).ToList();
        List<int> secondList = list.Skip(halfCount).ToList();
        return (firstList, secondList);
 }
}