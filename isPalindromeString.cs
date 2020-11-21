using System;
using System.Collections.Generic;
public class UserMainCode{
       public int isPalindromeString(string input1){
        input1=input1.ToLower();
        string op="";
        for(int i=input1.Length-1;i>=0;i--){
            op+=input1[i];
        }
        if(op==input1){
            return 2;
        }
        return 1;
        
    }
}