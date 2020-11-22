using System;
using System.Collections.Generic;
public class UserMainCode{
       public class Result{
	public int output1;
	public int output2;
       }
       public Result SimpleEncodedArray(int[] input1,int input2){ 
        int[] output=new int[input2];
        output[input2-1]=input1[input2-1];
        for(int i=input2-1;i>0;i--)
        {
            output[i-1]=input1[i-1]-output[i];
        }
        int sum=0;
        for(int i=0;i<input2;i++)
        {
            sum+=output[i];
        }

        Result res=new Result(){
               output1=output[0],
               output2=sum
       };
       return res;
     }
}