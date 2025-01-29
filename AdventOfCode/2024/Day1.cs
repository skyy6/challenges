    public static int AoC1() {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            int diffVal = 0;
            while(true){
                string input = Console.ReadLine();
                if(input == "exit"){
                    break;
                }
                list1.Add(Int32.Parse(input.Split("   ")[0]));
                list2.Add(Int32.Parse(input.Split("   ")[1]));

            }
            list1.Sort();
            list2.Sort();

            for(int i = 0; i < list1.Count; i++){
                diffVal += Math.Abs(list1[i] - list2[i]);
            }
            return diffVal;
    }
	
	
	 public static int AoC1part2() {
            List<int> list1 = new List<int>();
            Dictionary<int,int> dict = new Dictionary<int,int>();
            int similarVal = 0;
            while(true){
                string input = Console.ReadLine();
                if(input == "exit"){
                    break;
                }
                list1.Add(Int32.Parse(input.Split("   ")[0]));
                int val2 = Int32.Parse(input.Split("   ")[1]);
                if(!dict.ContainsKey(val2)){
                    dict.Add(val2, 1);
                }
                else{
                    dict[val2]++;
                }
            }
            list1.Sort();
            for(int i = 0; i < list1.Count; i++){
                if(dict.ContainsKey(list1[i])){
                    similarVal += list1[i] * dict[list1[i]];
                }
                else{

                }
            }
            return similarVal;