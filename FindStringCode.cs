using System;
using System.Collections.Generic;
public class UserMainCode{
       public int FindStringCode(string input1){ 
        string[] ip=input1.Split(' ');
        string op="";
        for(int i=0;i<ip.Length;i++){
            string s=ip[i].ToLower();
            int sum=0;
            int start=0;
            int end=s.Length-1;
            while(start<=end){
                if(start==end){
                    sum+=s[start]-'a'+1;
                }
                else{
                    sum+=Math.Abs((s[start]-'a'+1)-(s[end]-'a'+1));
                }
                start++;
                end--;
            }
            op+=sum;
        }
        return int.Parse(op);  
    }
}