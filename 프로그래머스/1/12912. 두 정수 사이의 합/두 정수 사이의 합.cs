using System;

public class Solution {
    public long solution(int a, int b) {
        long answer = 0;

        int start = Math.Min(a, b);     // a와 b중 작은 값을 반환
        int end = Math.Max(a, b);       // a와 b중 큰 값을 반환

        for( int i = start; i <= end; i++){
            answer += i;
        }
        
        return answer;
    }
}