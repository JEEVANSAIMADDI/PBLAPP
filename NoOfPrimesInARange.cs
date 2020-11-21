using System;
using System.Collections.Generic;
public class UserMainCode{
       public int countPrimesInRange(int input1,int input2){
             int c=0;
            for(int i=input1;i<=input2;i++){
                if(isPrime(i)){
                    c+=1;
                }
            }
            return c;
    }
     public static bool isPrime(int n){
        if(n<=1){
            return false;
        }
        for(int i=2;i<=Math.Sqrt(n);i++){
            if(n%i==0){
                return false;
            }
        }
        return true;
    }
}