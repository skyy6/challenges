   public static int AoC4() {

        List<List<char>> chars = new List<List<char>>();
        int val = 0;
            while(true){
                string input = Console.ReadLine();
                if(input == "exit"){
                    break;
                }
                List<char> list = new List<char>();
                for(int i = 0; i < input.Length; i++){
                    list.Add(input[i]);
                }
                chars.Add(list);
            }
            for(int i = 0; i < chars.Count; i++){
                for(int j = 0; j < chars[i].Count; j++){
                    char c = chars[i][j];
                    if(c == 'X'){
                        val += SearchLetters(chars, i, j);
                    }
                    else{
                        continue;
                    }
                }
            }
            return val;
        }

    private static int SearchLetters(List<List<char>> chars, int i, int j)
    {
        char[] arr = new char[3]{
            'M', 'A', 'S'
        };
        int counter = 0;
        int value = 0;
        try{
            for(int x = 1; x <= arr.Length; x++){
            if(chars[i][j+x] == arr[counter]){
                counter++;
                if(counter == 3){
                    value++;
                }
                continue;
            }
            else{
                counter = 0;
                break;
                }
            }
        }
        catch{
        }
        counter = 0;
        try{
            for(int x = 1; x <= arr.Length; x++){
            if(chars[i+x][j] == arr[counter]){
                counter++;
                if(counter == 3){
                    value++;
                }
                continue;
                }
                else{
                    counter = 0;
                    break;
                }
            }
        }
        
        catch{
        }
        counter = 0;
        try{
            for(int x = 1; x <= arr.Length; x++){
            if(chars[i+x][j+x] == arr[counter]){
                counter++;
                if(counter == 3){
                    value++;
                }
                continue;
                }
                else{
                    counter = 0;
                    break;
                }
            }
        }
        catch{
        }
        counter = 0;
        try{
            for(int x = 1; x <= arr.Length; x++){
            if(chars[i-x][j] == arr[counter]){
                counter++;
                if(counter == 3){
                    value++;
                }
                continue;
                }
                else{
                    counter = 0;
                    break;
                }
            }
        }
        catch{
        }
        counter = 0;
        try{
            for(int x = 1; x <= arr.Length; x++){
            if(chars[i][j-x] == arr[counter]){
                counter++;
                if(counter == 3){
                    value++;
                }
                continue;
                }
                else{
                    counter = 0;
                    break;
                }
            }
        }
        catch{
        }
        counter = 0;
        try{
            for(int x = 1; x <= arr.Length; x++){
            if(chars[i-x][j-x] == arr[counter]){
                counter++;
                if(counter == 3){
                    value++;
                }
                continue;
                }
                else{
                    counter = 0;
                    break;
                }
            }
        }
        catch{
        }
        counter = 0;
                try{
            for(int x = 1; x <= arr.Length; x++){
            if(chars[i+x][j-x] == arr[counter]){
                counter++;
                if(counter == 3){
                    value++;
                }
                continue;
                }
                else{
                    counter = 0;
                    break;
                }
            }
        }
        catch{
        }
        counter = 0;
                try{
            for(int x = 1; x <= arr.Length; x++){
            if(chars[i-x][j+x] == arr[counter]){
                counter++;
                if(counter == 3){
                    value++;
                }
                continue;
                }
                else{
                    counter = 0;
                    break;
                }
            }
        }
        catch{
        }

        return value;
    }





   public static int AoC4part2() {
        
        List<List<char>> chars = new List<List<char>>();
        int val = 0;
            while(true){
                string input = Console.ReadLine();
                if(input == "exit"){
                    break;
                }
                List<char> list = new List<char>();
                for(int i = 0; i < input.Length; i++){
                    list.Add(input[i]);
                }
                chars.Add(list);
            }
            for(int i = 0; i < chars.Count; i++){
                for(int j = 0; j < chars[i].Count; j++){
                    char c = chars[i][j];
                    if(c == 'A'){
                        val += SearchLettersp2(chars, i, j);
                    }
                    else{
                        continue;
                    }
                }
            }
            return val;
        }

    private static int SearchLettersp2(List<List<char>> chars, int i, int j)
    {
        int value = 0;
        try{
        if((chars[i-1][j-1] == 'M' && chars[i+1][j+1] =='S' || chars[i-1][j-1] == 'S' && chars[i+1][j+1] =='M') && (chars[i+1][j-1] == 'M' && chars[i-1][j+1] =='S' || chars[i+1][j-1] == 'S' && chars[i-1][j+1] =='M') ){
            value++;
        }
        }
        catch{
        }


        return value;
    }