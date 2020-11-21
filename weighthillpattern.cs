using System;
using System.Collections.Generic;
public class UserMainCode{
       public int TotalHillWeight(int input1,int input2,int input3){
       int s=0;
        for(int i=1;i<=input1;i++){
            s=s+(input2*i);
            input2+=input3;
        }
        return s;
     }
}