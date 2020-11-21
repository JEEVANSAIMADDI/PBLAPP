using System;
using System.Collections.Generic;
public class UserMainCode{
       public int nonRepeatedDigitsCount(int input1){ 
       int c=0;
       int[] arr=new int[10];
        while(input1!=0){
            arr[input1%10]++;
            input1/=10;
        }
        for(int i=0;i<10;i++){
            if(arr[i]==1){
                c+=1;
            }
        }
        return c;
    }
}