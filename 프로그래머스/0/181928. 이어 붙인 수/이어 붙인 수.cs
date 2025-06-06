using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        string oddNums = "";
        string evenNums = "";
        for(int i=0; i<num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
            {
                evenNums += num_list[i].ToString();
            }
            else
            {
                oddNums += num_list[i].ToString();
            }
        }
        answer = int.Parse(evenNums) + int.Parse(oddNums);
        return answer;
    }
}