using System;

public class Solution {
    public string solution(string code) {
        string ret = "";
        int mode = 0;
        char[] codeChar = code.ToCharArray();
        for (int i=0; i<code.Length; i++){
            if(mode == 0)
            {
                if (codeChar[i] != '1'){
                    if (i % 2 == 0)
                    {
                        ret += codeChar[i];
                    }
                }
                else
                {
                    mode = 1;
                }
            }
            else if (mode == 1)
            {
                if(codeChar[i] != '1'){
                    if (i % 2 == 1){
                        ret += codeChar[i];
                    }
                }
                else{
                    mode = 0;
                }
            }
        }
        if (ret.Length == 0){
            return "EMPTY";
        }
        return ret;
    }
}