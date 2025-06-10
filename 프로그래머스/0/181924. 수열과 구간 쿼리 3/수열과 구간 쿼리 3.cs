using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        for (int i=0; i<queries.GetLength(0); i++){
            for (int j = 0; j < queries.GetLength(1)-1; j++)
            {
                int temp = arr[queries[i, j]];
                arr[queries[i, j]] = arr[queries[i, j+1]];
                arr[queries[i, j+1]] = temp;
            }
        }
        return arr;
    }
}