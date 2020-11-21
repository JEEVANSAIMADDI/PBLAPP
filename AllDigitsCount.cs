using System;
using System.Collections.Generic;
public class UserMainCode{
       public int allDigitsCount(int input1){ 
       int c=0;
        while(input1!=0){
            c+=1;
            input1/=10;
        }
        return c;  
    }
}