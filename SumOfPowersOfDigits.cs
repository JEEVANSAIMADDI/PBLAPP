using System;
using System.Collections.Generic;
public class UserMainCode{
       public int sumOfPowersOfDigits(int input1){
        string ip=input1.ToString();
        int sum=1;
        for(int  i=0;i<ip.Length-1;i++){
            sum+=(int)Math.Pow(ip[i]-'0',ip[i+1]-'0');
        }
        return sum;
    }
}