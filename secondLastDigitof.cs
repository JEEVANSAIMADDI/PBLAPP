using System;
using System.Collections.Generic;
public class UserMainCode{ 
        public int secondLastDigitOf(int input1){
        input1=Math.Abs(input1);
        if(input1.ToString().Length==1){
            return -1;
        }
        return (input1/10)%10;
    }
}
   