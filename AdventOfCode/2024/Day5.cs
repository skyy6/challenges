 public static int AoC5() {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        int val = 0;
            while(true){
                string input = Console.ReadLine();
                if(input == "exit"){
                    break;
                }
                int val1 = int.Parse(input.Split('|')[0]);
                int val2 = int.Parse(input.Split('|')[1]);
                if(!dict.ContainsKey(val2)){
                    List<int> list = new List<int>(){
                        val1
                    };
                    dict.Add(val2, list);
                }
                else{
                    dict[val2].Add(val1);
                }
            }
            while(true){
                string input = Console.ReadLine();
                bool isWorking = true;
                if(input == "exit"){
                    break;
                }
                List<int> list = new List<int>();
                list = input.Split(',').Select(x => int.Parse(x)).ToList();
                try{
                    for(int i = 1; i < list.Count; i++){
                        if(!dict[list[i]].Contains(list[i-1])){
                            isWorking = false;
                        }
                    }
                }
                catch{
                    isWorking = false;
                }
                if(isWorking){
                    val+= list[list.Count/2];
                }
            }
            return val;
        }
		
		/********************************************************************************************************/
		
	public static int AoC5part2() {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        int val = 0;
            while(true){
                string input = Console.ReadLine();
                if(input == "exit"){
                    break;
                }
                int val1 = int.Parse(input.Split('|')[0]);
                int val2 = int.Parse(input.Split('|')[1]);
                if(!dict.ContainsKey(val2)){
                    List<int> list = new List<int>(){
                        val1
                    };
                    dict.Add(val2, list);
                }
                else{
                    dict[val2].Add(val1);
                }
            }
            while(true){
                string input = Console.ReadLine();
                bool isOrdered = true;
                if(input == "exit"){
                    break;
                }
                List<int> list = new List<int>();
                list = input.Split(',').Select(x => int.Parse(x)).ToList();
                try{
                    for(int i = 1; i < list.Count; i++){
                        if(!dict[list[i]].Contains(list[i-1])){
                            isOrdered = false;
                        }
                    }
                }
                catch{
                    isOrdered = false;
                }
                if(!isOrdered){
                    for(int i = 1; i < list.Count; i++){
                        for(int j = 0; j < list.Count; j++){
                            try{
                                if(dict[list[i]].Contains(list[j])){
                                    continue;
                                }
                                else{
                                int temp = list[j];
                                list[j] = list[i];
                                list[i] = temp;  
                                }  
                            }
                            catch{
                                int temp = list[j];
                                list[j] = list[i];
                                list[i] = temp;
                            }
                        }
                    }
                    val+= list[list.Count/2];
                }

            }
            return val;
        }	