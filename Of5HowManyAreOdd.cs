using System;
using System.Collections.Generic;
public class UserMainCode{ 
        public int countOdds(int input1,int input2,int input3,int input4,int input5){
        int[] ip={input1,input2,input3,input4,input5};
        int c=0;
       foreach(int each in ip){
       if(each%2!=0){
            c+=1;
           }
      }
      return c;
   }
}
