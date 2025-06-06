using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = 0;
        char[] c = new char[control.Length];
        for (int i=0; i<control.Length; i++){
            c[i] = control.ToCharArray()[i];
            if (c[i] == 'w'){
                n += 1;
            }
            else if ( c[i] == 's'){
                n -= 1;
            }
            else if(c[i] =='d'){
                n += 10;
            }
            else if(c[i] == 'a'){
                n -= 10;
            }
        }
        return answer + n;
    }
}