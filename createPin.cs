using System;
using System.Collections.Generic;
public class UserMainCode{
       public int createPin(int input1,int input2,int input3){ 
        int[] units={input1%10,input2%10,input3%10};
        int[] tens={(input1/10)%10,(input2/10)%10,(input3/10)%10};
        int[] huns={(input1/100)%10,(input2/100)%10,(input3/100)%10};
        int[] thous={input1%10,input2%10,input3%10,(input1/10)%10,(input2/10)%10,(input3/10)%10,(input1/100)%10,(input2/100)%10,(input3/100)%10};
        Array.Sort(units);
        Array.Sort(tens);
        Array.Sort(huns);
        Array.Sort(thous);
        return units[0]+(tens[0]*10)+(huns[0]*100)+(thous[thous.Length-1]*1000);
    }
}