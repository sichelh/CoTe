using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        int abPlus = int.Parse(a.ToString() + b.ToString());
        int abMul = 2 * a * b;
        
        if (abPlus > abMul){
            answer = abPlus;
        }
        else{
            answer = abMul;
        }
        
        return answer;
    }
}