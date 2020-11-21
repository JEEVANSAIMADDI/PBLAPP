using System;
using System.Collections.Generic;
public class UserMainCode{
       public int nthFibonacci(int input1){
        int a=0,b=1,c=0;
        for(int i=2;i<input1;i++)
        {
            c=a+b;
            a=b;
            b=c;
        }
        return c;
    }
}
