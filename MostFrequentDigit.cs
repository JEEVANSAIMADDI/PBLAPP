using System;
using System.Collections.Generic;
public class UserMainCode{
       public int MostFrequentDigit(int input1,int input2,int input3,int input4,){
        string ip=input1.ToString()+input2.ToString()+input3.ToString()+input4.ToString();
        int[] arr=new int[10];
        for(int i=0;i<10;i++){
            arr[i]=0;
        }
        for(int i=0;i<ip.Length;i++){
            arr[ip[i]-'0']++;
        }
        int max=0;
        for(int i=0;i<10;i++){
            if(arr[i]>=arr[max]){
                max=i;
            }
        }
        return max;
    }
}