using System;
using System.Collections.Generic;
public class UserMainCode{
       public int isPalNum(int input1){         
        int n=input1,rev=0;
        while(n!=0){
            rev=rev*10+n%10;
            n/=10;
        }
        if(rev==input1){
            return 2;
        }
        else{
            return 1;
        }      
    }
}