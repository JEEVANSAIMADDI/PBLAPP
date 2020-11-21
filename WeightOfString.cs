using System;
using System.Collections.Generic;
public class UserMainCode{
       public int WeightOfString(string input1,int input2){
       int s=0;
        foreach(char ch in input1.ToLower()){
            if(input2==0 && "aeiou".IndexOf(ch)>=0){
                continue;
            }
            if(Char.IsLetter(ch)){
                s+=ch-'a'+1;
            }
        }
        return s;
    }
}