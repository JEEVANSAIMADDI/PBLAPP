using System;
using System.Collections.Generic;
using System.Linq;
public class UserMainCode{
       public class Result{
	public int output1;
	public int output2;
       }
       public Result DecreasingSequence(int[] input1,int input2){ 
        int[] freq=Enumerable.Repeat(1,input2).ToArray();
        int x=0;
        for(int i=0;i<input2-1;i++){
            if(input1[i]>input1[i+1]){
                freq[x]++;
            }
            else{
                x++;
            }
        }
        int max=0,cnt=0;
        for(int i=0;i<input2;i++){
            if(freq[i]>1){
                if(freq[i]>max){
                    max=freq[i];
                }
                cnt+=1;
            }
        }
        Result r=new Result(){
            output1=cnt,
            output2=max
        };
        return r;
    }
}