using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;

        Array.Sort(score);
        Array.Reverse(score);

        for(int i = 0; i + m <= score.Length;i += m){
            int min = score[i + m - 1];
            answer += min * m;
        }
        
        return answer;
    }
}
