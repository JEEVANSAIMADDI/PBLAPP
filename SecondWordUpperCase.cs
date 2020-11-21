using System;
using System.Collections.Generic;
public class UserMainCode{
       public string secondWordUpperCase(string input1){
        string[] ip=input1.Split(' ');
        if(ip.Length<2){
            return "LESS";
        }
        return ip[1].ToUpper();
    }
}