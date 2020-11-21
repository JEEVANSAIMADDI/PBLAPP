using System;
using System.Collections.Generic;
public class UserMainCode{
       public int digitSum(int input1){         
        int sum=0;
        while(input1!=0){
            sum+=input1%10;
            input1/=10;
        }
        if(sum==0){
            return 0;
        }
        else if(sum%9==0 && sum>0){
            return 9;
        }
        else if(sum%9==0 && sum<0){
            return -9;
        }
        else{
            return sum%9;
        }
    }
}