using System;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        int[] countX = new int[10];
        int[] countY = new int[10];
        StringBuilder sb = new StringBuilder();

        foreach (char c in X)
        {
            countX[c - '0']++;
        }
        foreach (char c in Y)
        {
            countY[c - '0']++;
        }

        for (int i = 9; i >= 0; i--)
        {
            int minCount = Math.Min(countX[i], countY[i]);
            sb.Append(new String((char)(i+'0'), minCount));
        }
        answer = sb.ToString();

        if (answer == "")
        {
            answer = "-1";
        }

        if (answer[0] == '0')
        {
            answer = "0";
        }

        return answer;
    }
}