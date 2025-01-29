public static int AoC2() {

        int val = 0;
            while(true){
                bool doAdd = true;
                bool doAdd2 = true;
                string input = Console.ReadLine();
                if(input == "exit"){
                    break;
                }
                int[] arr = Array.ConvertAll(input.Split(" "), i => int.Parse(i));
                int checkSum = arr[0];
                for(int i = 1; i < arr.Length; i++){ 
                    if(arr[i] < arr[i-1] && Math.Abs(arr[i] - arr[i-1]) <= 3){
                        continue;
                    }         
                    else{
                        doAdd = false;
                        break;
                    }
                }
                for(int i = 1; i < arr.Length; i++){
                  if(arr[i] > arr[i-1] && Math.Abs(arr[i] - arr[i-1]) <= 3){
                        continue;
                    }
                    else{
                        doAdd2 = false;
                        break;
                    }          
                }
                if(doAdd||doAdd2) {
                    val++;
                }
            }

        return val;
    }
	
	    public static int AoC2part2() {

        int val = 0;
            while(true){
                bool doAdd = true;
                bool doAdd2 = true;
                string input = Console.ReadLine();
                if(input == "exit"){
                    break;
                }
                int[] arr = Array.ConvertAll(input.Split(" "), i => int.Parse(i));
                int checkSum = arr[0];
                for(int i = 1; i < arr.Length; i++){ 
                    if(arr[i] < arr[i-1] && Math.Abs(arr[i] - arr[i-1]) <= 3){
                        continue;
                    }         
                    else{
                        doAdd = false;
                        break;
                    }
                }
                for(int i = 1; i < arr.Length; i++){
                  if(arr[i] > arr[i-1] && Math.Abs(arr[i] - arr[i-1]) <= 3){
                        continue;
                    }
                    else{
                        doAdd2 = false;
                        break;
                    }          
                }
                if(doAdd||doAdd2) {
                    val++;
                }
                else if (loopCheckWithRemove(arr)){
                    val++;
                }
            }

        return val;
    }
    public static bool loopCheckWithRemove(int[] arr){
                    
                    List<int> list = new List<int>();
                    for(int j = 0; j < arr.Length; j++){
                        bool doAdd = true;
                        list = arr.ToList();
                        list.RemoveAt(j);
                        for(int i = 1; i < list.Count; i++){
                        if(list[i] > list[i-1] && Math.Abs(list[i] - list[i-1]) <= 3){
                        continue;
                        }
                        else{
                            doAdd = false;
                            break;
                        } 
                        }
                        if(doAdd){
                            return true;
                        }
                   }
                for(int j = 0; j < arr.Length; j++){
                    bool doAdd2 = true;
                    list = arr.ToList();
                    list.RemoveAt(j);  
                    for(int i = 1; i < list.Count; i++){
                  if(list[i] < list[i-1] && Math.Abs(list[i] - list[i-1]) <= 3){
                        continue;
                    }
                    else{
                        doAdd2 = false;
                        break;
                    }
                              
                }
                if(doAdd2){
                    return true;
                }
                }
                    return false;

    }