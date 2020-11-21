using System;
using System.Collections.Generic;
public class UserMainCode{ 
        public int countEvensOdds(int input1,int input2,int input3,int input4,int input5,string input6){
        int[] ip={input1,input2,input3,input4,input5};
        int e=0,o=0;
        foreach(int each in ip){
        if(each%2==0){
            e+=1;
        }
        else{
            o+=1;
        }
    }
       if(input6.Equals("even")){
           return e;
       }
       else{
          return o;
      }
   }
}