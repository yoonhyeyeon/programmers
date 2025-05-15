using System;

public class Solution {
    public int solution(int n) {
        double answer = Math.Sqrt(n);
        long intSqrt = (long)answer;

        if( intSqrt * intSqrt == n ){
            return 1;
        }else{
            return 2;
        }
    }
}