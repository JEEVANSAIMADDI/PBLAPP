using System;
using System.Collections.Generic;
public class UserMainCode{
       public int isPrime(int input1){ 
       if(n<=1){
            return 1;
        }
        for(int i=2;i<=Math.Sqrt(n);i++){
            if(n%i==0){
                return 1;
            }
        }
        return 2;
    }
}