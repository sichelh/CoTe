using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        int answer = 0;
        if (eq == "="){
            if(ineq == ">"){
                answer = n >= m ? 1 : 0;
            }
            else if (ineq == "<"){
                answer = n <= m ? 1 : 0;
            }
            else{
                return 0;
            }
        }
        else if(eq == "!"){
            if(ineq == ">"){
                answer = n > m ? 1 : 0;
            }
            else if (ineq == "<"){
                answer = n < m ? 1 : 0;
            }
            else{
                return 0;
            }
        }
        else{
            return 0;
        }
        return answer;
    }
}