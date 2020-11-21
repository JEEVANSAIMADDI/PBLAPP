using System;
using System.Collections.Generic;
public class UserMainCode{
       public int nthFibonacci(int input1){ 
        int num=1,c=0,op=0;
        while(true){
            if(isPrime(num)){
                c+=1;
            }
            if(c==input1){
                op=num;
                break;
            }
            num+=1;
        }
        return op;
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