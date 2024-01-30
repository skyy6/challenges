using System;
using System.Collections.Generic;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string password = Console.ReadLine();
        string userInput = Console.ReadLine();
    
        char[] reverseCase = password.ToCharArray(0, password.Length);

        bool canLogin = false;

        for(int i = 0; i <= 9; i++){
            StringBuilder sb = new StringBuilder(userInput);
            StringBuilder sbR = new StringBuilder(userInput);
            string digit = i.ToString();
            sb.Append(digit);
            sbR.Insert(0,digit);
            if(sb.ToString() == password || sbR.ToString() == password){
                canLogin = true;              
            }
        }
        for(int i = 0; i < reverseCase.Length; i++){
            if(char.IsUpper(reverseCase[i])){
                reverseCase[i] = char.ToLower(reverseCase[i]);
                continue;
            }
            if(char.IsLower(reverseCase[i])){
                reverseCase[i] = char.ToUpper(reverseCase[i]);
            }             
        }
        if(password == userInput || new string(reverseCase) == userInput ){
            canLogin = true;
        }
        if(canLogin){
            Console.WriteLine("Yes");
        }
        else{
            Console.WriteLine("No");
        }
    }
}