using System;

public class Solution {
    public int solution(int a, int d, bool[] included) {
        int answer = 0;
        int[] arr = new int[included.Length];
        for (int i=0; i<included.Length; i++)
        {
            arr[i] = a+d*i;
            if (included[i])
            {
                answer += arr[i];
            }
        }
        return answer;
    }
}