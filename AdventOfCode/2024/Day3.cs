 public static long AoC3() {

        long val = 0;
            while(true){
                string input = Console.ReadLine();
                bool doMul = true;
                StringBuilder sb1 = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                int counter = 0;
                if(input == "exit"){
                    break;
                }
                List<char> inputList = new List<char>(){
                    'm',
                    'u',
                    'l',
                    '(',
                    ',',
                    ')'
                };
                 List<char> dontList = new List<char>(){'d', 'o', '(', ')'}; 
                 List<char> doList = new List<char>(){'d', 'o','n','\'', 't', '(', ')' };     
                for(int i = 0; i < input.Length; i++){
                    if(doMul){
                    if(input[i] == inputList[counter]){
                        counter++;
                        if(counter == 6){
                        val += int.Parse(sb1.ToString()) * int.Parse(sb2.ToString());
                        sb1.Clear();
                        sb2.Clear();
                        counter = 0;
                        }
                    }
                    else if(counter == 4 && char.IsDigit(input[i])){
                        sb1.Append(input[i]);
                    }
                    else if(counter == 5 && char.IsDigit(input[i])){
                        sb2.Append(input[i]);
                    }
                    else{
                        counter = 0;
                        sb1.Clear();
                        sb2.Clear();
                    }
                }

            }
            }


                return val;
        }


    public static long AoC3part2() {

        long val = 0;
        bool doMul = true;

            while(true){
                string input = Console.ReadLine();
                int doCounter = 0;
                StringBuilder sb1 = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                int counter = 0;
                if(input == "exit"){
                    break;
                }
                List<char> inputList = new List<char>(){'m','u','l','(',',',')'};
                List<char> doList = new List<char>(){'d', 'o', '(', ')'}; 
                List<char> dontList = new List<char>(){'d', 'o','n','\'', 't', '(', ')' };     
                for(int i = 0; i < input.Length; i++){
                    if(doMul)
                    {
                        
                        if(input[i] == dontList[doCounter]){
                            doCounter++;
                            if(doCounter == 7){
                                doMul = false;
                                doCounter = 0;
                                continue;
                            }
                            continue;
                        }
                        else{
                            doCounter = 0;
                        }

                    if(input[i] == inputList[counter]){
                        counter++;
                        if(counter == 6){
                        val += int.Parse(sb1.ToString()) * int.Parse(sb2.ToString());
                        sb1.Clear();
                        sb2.Clear();
                        counter = 0;
                        }
                    }
                    else if(counter == 4 && char.IsDigit(input[i])){
                        sb1.Append(input[i]);
                    }
                    else if(counter == 5 && char.IsDigit(input[i])){
                        sb2.Append(input[i]);
                    }
                    else{
                        counter = 0;
                        sb1.Clear();
                        sb2.Clear();
                    }

                    
                }
                else{
                
                if(input[i] == doList[doCounter]){
                            doCounter++;
                            if(doCounter == 4){
                                doMul = true;
                                doCounter = 0;
                                continue;
                            }
                        }
                        else{
                            doCounter = 0;
                        }
                }

            }
        }
            

                return val;
    }