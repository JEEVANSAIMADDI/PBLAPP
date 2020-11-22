using System;
using System.Collections.Generic;
public class UserMainCode{
       public int getCodeThroughStrings(string input1){ 
        string[] ip=input1.Split(' ');
        int len=0;
        foreach(string s in ip){
            len+=s.Length;
        }
        if(len==0){
            return 0;
        }
        else if(len%9==0){
            return 9;
        }
        return len%9;
    }
}