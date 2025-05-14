using System;

public class Solution {
    public long solution(long n) {

        // n의 제곱근
        double sqrt = Math.Sqrt(n);
        
        if( sqrt == (long)sqrt ){
            return (long)(sqrt+1) * (long)(sqrt+1);
        }else{
            return -1;
        }
        
    }
}