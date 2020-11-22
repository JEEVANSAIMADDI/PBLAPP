using System;
using System.Collections.Generic;
public class UserMainCode{
       public int SumofSumsofDigitsinCyclicorder(int input1){
        int sum=0;
        string ip=input1.ToString();
        for(int i=0;i<ip.Length;i++){
            for(int j=i;j<ip.Length;j++){
                sum+=ip[j]-'0';
            }
        }
        return sum;  
    }
}