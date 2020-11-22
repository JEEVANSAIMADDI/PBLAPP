using System;
using System.Collections.Generic;
public class UserMainCode{
       public class Result{
	public int output1;
	public int output2;
	public int output3;
       }
       public Result EncodingThreeStrings(string input1,string input2,string input3){ 
        string[] ip={input1,input2,input3};
        string fst="",mid="",lst="";
        foreach(string each in ip){
            string s=each;
            int len=s.Length;
            if(len%3==0){
                fst+=s.Substring(0,len/3);
                mid+=s.Substring(len/3,len/3);
                lst+=s.Substring(2*len/3);
            }
            else if(len%3==1){
                fst+=s.Substring(0,len/3);
                mid+=s.Substring(len/3,len/3+1);
                lst+=s.Substring(2*(len/3)+1);
            }
            else{
                fst+=s.Substring(0,len/3+1);
                mid+=s.Substring(len/3+1,len/3);
                lst+=s.Substring(2*(len/3)+1);
            }
        }
        string last="";
        foreach(char ch in lst){
            if(Char.IsLower(ch)){
                last+=Char.ToUpper(ch);
            }
            else{
                last+=Char.ToLower(ch);
            }
        }
        Result r=new Result(){
            output1=fst,
            output2=mid,
            output3=last
        };
        return r;
    }
}