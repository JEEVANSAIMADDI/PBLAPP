using System;
using System.Collections.Generic;
public class UserMainCode{
       public int digitSumOdd(int input1){     
       int sum=0;
        while(input1!=0){
            int r=input1%10;
            if(r%2!=0){
                sum+=r;
            }
            input1/=10;
        }
        return sum;
    }
}   