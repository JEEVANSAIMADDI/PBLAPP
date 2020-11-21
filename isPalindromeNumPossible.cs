using System;
using System.Collections.Generic;
public class UserMainCode{
       public int isPalNumPossible(int input1){         
       int[] arr=new int[10];
        int c=0;
        while(input1!=0){
            arr[input1%10]++;
            input1/=10;
        }
        for(int i=0;i<10;i++){
            if(arr[i]%2!=0){
                c+=1;
            }
            if(c>1){
                return 1;
            }
        }
        return 2;
    }
}