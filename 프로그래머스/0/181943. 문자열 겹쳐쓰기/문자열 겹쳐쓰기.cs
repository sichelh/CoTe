using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string answer = "";
        string frontString = my_string.Substring(0, s);
        string endString = my_string.Substring(s+overwrite_string.Length);
        answer = frontString + overwrite_string + endString;
        
        return answer;
    }
}