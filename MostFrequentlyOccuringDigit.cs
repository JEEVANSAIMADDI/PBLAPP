using System;
using System.Collections.Generic;
public class UserMainCode{
       public int MostFrequentlyOccuringDigit(int[] input1){
        string s="";
        foreach(int each in input1){
            s+=each;
        }
        int[] freq=Enumerable.Repeat(0,10).ToArray();
        foreach(char ch in s){
            freq[ch-'0']++;
        }
        int max=freq[0];
        int ind=0;
        for(int i=0;i<10;i++){
            if(freq[i]>=max){
                max=freq[i];
                ind=i;
            }
        }
        return ind;
    }
}