using System;
using System.Collections.Generic;
public class UserMainCode{
       public int nFactorial(int input1){
        int fact=1;
        for(int i=1;i<=input1;i++){
            fact=fact*i;
        }
        return fact;
    }
}