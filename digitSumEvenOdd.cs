using System;
using System.Collections.Generic;
public class UserMainCode{
       public int digitSumEvenOdd(int input1){     
        int e=0,o=0;
        while(input1!=0){
            int r=input1%10;
            if(r%2==0){
                e+=r;
            }
            else{
                o+=r;
            }
            input1/=10;
        }
        if(input2.Equals("even")){
            return e;
        }
        return o;
    }
}   
    