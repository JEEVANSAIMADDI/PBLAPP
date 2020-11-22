using System;
using System.Collections.Generic;
public class UserMainCode{
       public string IdentifyPossibleWords(string input1,string input2){
        input1=input1.ToUpper();
        string[] ip=input2.Split(':');
        string op="";
        int index=input1.IndexOf('_');
        for(int i=0;i< ip.Length;i++){
            string s=ip[i].ToUpper();
            if(input1.Length==s.Length && s.Equals(input1.Replace('_',s[index]))){
                op+=s+":";
            }
        }
        if(op.Length==0){
            return "ERROR-009";
        }
        return op.Substring(0,op.Length-1);
    }
}
